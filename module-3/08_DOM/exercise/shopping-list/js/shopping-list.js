
// add pageTitle

let pageTitle = "My Shopping List";

// add groceries

let groceries = 
[
  "Burritos", "Cold Burritos", "Hot Burritos", "Half-Eaten Burritos", "Programming Books", "Dill Pickle Chips", "Diet Doctor Pepper", "Diet Doctor K", "Croissants", "Sushi"
];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  const heading = document.getElementById("title");
  heading.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const shoppingList = document.getElementById("groceries");
  groceries.forEach((item) => {
    const li = document.createElement("li");
    li.innerText = item;
    shoppingList.appendChild(li);
  })
}

/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {
  let allListItems = document.querySelectorAll("li");
  allListItems.forEach((item) => item.classList.add("completed"));
}

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
