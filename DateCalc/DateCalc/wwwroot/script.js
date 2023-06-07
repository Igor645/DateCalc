let newDate = document.querySelector(".inputField");
let calcButton = document.querySelector(".calcButton");

calcButton.addEventListener("click", (event) => {
	event.preventDefault()
	calculateDate();
})

function calculateDate() {
	fetch(`https://localhost:7075/Date/datedifference?inputDate=${newDate.value}`)
		.then(response => {
			if (response.ok) {
				return response.json();
			} else {
				throw new Error("Error: " + response.status);
			}
		})
		.then(data => {
			document.getElementById("result").textContent = data.duration;
		})
		.catch(error => {
			console.error(error);
		});
}
