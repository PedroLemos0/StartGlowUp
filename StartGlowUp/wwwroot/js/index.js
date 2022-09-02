const button = document.querySelector('#like');
const number = document.querySelector('#number');

let num = 0

button.addEventListener('click', () => {
  number.innerHTML = num + 1
})