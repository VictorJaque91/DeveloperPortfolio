// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// ==========================================================================
// Skill bars (About page): fill each category when it scrolls into view.
// Progressive enhancement - without JS (or with reduced motion) the bars
// are rendered full by the CSS, so nothing depends on this script.
// ==========================================================================
(() => {
    const categories = document.querySelectorAll("[data-skill-category]");
    if (categories.length === 0) return;

    const prefersReducedMotion = window.matchMedia("(prefers-reduced-motion: reduce)").matches;
    if (prefersReducedMotion || !("IntersectionObserver" in window)) return;

    const observer = new IntersectionObserver((entries) => {
        entries.forEach((entry) => {
            if (entry.isIntersecting) {
                entry.target.classList.remove("is-pending");
                observer.unobserve(entry.target); // animate only once
            }
        });
        // rootMargin pulls the trigger line 25% up from the bottom of the viewport,
        // so the bars fill as you scroll them into view - not the instant the section
        // merely peeks in at the bottom on load. A percentage (not a fixed px) scales
        // with the window, so even very tall windows wait for a real scroll.
    }, { threshold: 0, rootMargin: "0px 0px -25% 0px" });

    categories.forEach((category) => {
        category.classList.add("is-pending");
        observer.observe(category);
    });
})();


// ==========================================================================
// Theme toggle (navbar): switch between dark and light.
// The script in <head> (_Layout.cshtml) has already picked the theme before
// the page was drawn, so this only reads it and handles clicks.
// ==========================================================================
(() => {
    const button = document.querySelector("[data-theme-toggle]");
    if (!button) return;

    const root = document.documentElement;

    // The label says what the button will DO, like the hamburger menu's label
    const updateLabel = () => {
        const isDark = root.dataset.theme !== "light";
        button.setAttribute("aria-label", isDark ? "Switch to light theme" : "Switch to dark theme");
    };

    button.addEventListener("click", () => {
        const next = root.dataset.theme === "light" ? "dark" : "light";
        root.dataset.theme = next;
        updateLabel();

        // Saved only when the user actively chooses. Saving on every page load
        // would lock in the OS setting, and the site would stop following it.
        try {
            localStorage.setItem("theme", next);
        } catch {
            // Storage blocked: the theme still works, it just isn't remembered
        }
    });

    updateLabel();
})();


// ==========================================================================
// Mobile menu: Escape closes it and moves focus back to the hamburger button.
// Bootstrap's collapse doesn't do this on its own (WCAG 2.1.1 keyboard).
// ==========================================================================
(() => {
    const menu = document.getElementById("navbarSupportedContent");
    const toggler = document.querySelector(".navbar-toggler");
    if (!menu || !toggler || typeof bootstrap === "undefined") return;

    document.addEventListener("keydown", (event) => {
        if (event.key !== "Escape" || !menu.classList.contains("show")) return;

        bootstrap.Collapse.getOrCreateInstance(menu, { toggle: false }).hide();
        toggler.focus();
    });
})();


// ==========================================================================
// Project filter (Projects page): show only projects using a technology.
// The buttons are rendered hidden; without JavaScript every project is
// simply shown and no useless buttons are visible.
// ==========================================================================
(() => {
    const filter = document.querySelector("[data-project-filter]");
    if (!filter) return;

    const buttons = filter.querySelectorAll("[data-filter]");
    const cards = document.querySelectorAll("[data-technologies]");
    const count = document.querySelector("[data-project-count]");

    const applyFilter = (technology) => {
        let visible = 0;

        cards.forEach((card) => {
            // Technologies are stored as "C#|.NET|WPF" on each card
            const technologies = card.dataset.technologies.split("|");
            const show = technology === "All" || technologies.includes(technology);
            card.hidden = !show;
            if (show) visible++;
        });

        // aria-pressed is both the state for screen readers and the hook for the CSS
        buttons.forEach((button) => {
            button.setAttribute("aria-pressed", String(button.dataset.filter === technology));
        });

        // The count is in an aria-live region, so screen readers announce the change
        if (count) {
            count.textContent = `Showing ${visible} of ${cards.length} projects`;
        }
    };

    buttons.forEach((button) => {
        button.addEventListener("click", () => applyFilter(button.dataset.filter));
    });

    filter.hidden = false;
    if (count) count.hidden = false;
})();


// ==========================================================================
// Project dialogs ("Read more", Projects page).
// Native <dialog> + showModal() gives focus trapping, Escape to close and an
// inert page behind it for free. Like the filter, the buttons start hidden.
// ==========================================================================
(() => {
    const openButtons = document.querySelectorAll("[data-open-dialog]");

    openButtons.forEach((button) => {
        const dialog = document.getElementById(button.dataset.openDialog);
        if (!dialog) return;

        button.hidden = false;

        button.addEventListener("click", () => dialog.showModal());

        dialog.addEventListener("click", (event) => {
            // The padding is on the inner div, so a click on the <dialog> itself
            // means a click on the backdrop. The close button also closes it.
            if (event.target === dialog || event.target.closest("[data-close-dialog]")) {
                dialog.close();
            }
        });

        // Put focus back on the button that opened the dialog
        dialog.addEventListener("close", () => button.focus());
    });
})();
