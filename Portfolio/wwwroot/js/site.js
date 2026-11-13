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
    }, { threshold: 0.3 });

    categories.forEach((category) => {
        category.classList.add("is-pending");
        observer.observe(category);
    });
})();
