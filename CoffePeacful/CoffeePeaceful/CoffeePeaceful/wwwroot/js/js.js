const login = document.querySelector('.btnPopup');
const wrapper = document.querySelector('.wrapper');
const loginLink = document.querySelector('.login-link');
const registerLink = document.querySelector('.register-link');
const closeWraper = document.querySelector('.close');

console.log(login);

closeWraper.addEventListener('click', () => {
    wrapper.classList.remove('show');
    wrapper.classList.add('show2');
})

registerLink.addEventListener('click', () => {
    wrapper.classList.add('active');
})

loginLink.addEventListener('click', () => {
    wrapper.classList.remove('active');
})

login.addEventListener('click', () => {
    wrapper.classList.add('show');
    wrapper.classList.remove('show2');
})