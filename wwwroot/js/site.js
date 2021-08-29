// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function outputUpdate(value) {
	document.querySelector('#displayguess').value = value;
}

const guessForm = document.forms['guess'];

/*
guessForm.addEventListener('submit', function (e) {
	e.preventDefault();
	const value = guessForm.querySelector('input[type="range"]').value;
	console.log(value);
});
*/