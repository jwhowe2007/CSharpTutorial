'use strict'; // Let's be strict about our JS!

// Main index JS
const themeSwitcher = document.querySelector('#themeSwitch');

themeSwitcher.addEventListener('click', function() {
    document.body.classList.toggle('light-theme');
    document.body.classList.toggle('dark-theme');

    if(document.body.className == 'light-theme') {
        this.textContent = "Use Dark";
    } else {
        this.textContent = "Use Light";
    }
});