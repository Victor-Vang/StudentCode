/**
 * Write a function called isAdmitted. It will check entrance
 * scores and return true if the student is admitted and
 * false if rejected. It takes three parameters:
 *
 *     * gpa
 *     * satScore (optional)
 *     * recommendation (optional)
 *
 * Admit them--return true--if:
 * gpa is above 4.0 OR
 * SAT score is above 1300 OR
 * gpa is above 3.0 and they have a recommendation OR
 * SAT score is above 1200 and they have a recommendation
 * OTHERWISE reject it
 *
 * @param {number} gpa the GPA of the student, between 4.2 and 1.0
 * @param {number} [satScore=0] the student's SAT score
 * @param {boolean} [recommendation=false] does the student have a recommendation
 * @returns {boolean} true if they are admitted
 */

function isAdmitted(gpa, satScore = 0, recommendation = false)
{
    if (gpa > 4.0)
    {
        return true;
    }
    else if (satScore > 1300)
    {
        return true;
    }
    else if (gpa > 3.0 && recommendation === true)
    {
        return true;
    }
    else if (satScore > 1200 && recommendation ===true)
    {
        return true;
    }
    else
    {
        return false;
    }
}

/**
 * Write a function called useParameterToFilterArray that takes an anonymous
 * function and uses that in the `unfilteredArray` filter function. Return the result.
 *
 * @param {function} filterFunction the function to filter with
 * @returns {number[]} the filtered array
 */
let unfilteredArray = [1, 2, 3, 4, 5, 6];

function useParameterToFilterArray(filterFunction)
{
    const result = unfilteredArray.filter(filterFunction);
    return result;
}

// function useParameterToFilterArray(filterFunction)
// {
//     const result = unfilteredArray.filter((num) => {return num;});
// }

// let useParameterToFilterArray = unfilteredArray.filter((number) => {return number;});


/**
 * Write a function called makeNumber that takes two strings
 * of digits, concatenates them together, and returns
 * the value as a number.
 *
 * So if two strings are passed in "42293" and "443", then this function
 * returns the number 42293443.
 *
 * @param {string} first the first string of digits to concatenate
 * @param {string} [second=''] the second string of digits to concatenate
 * @returns {number} the resultant number
 */

function makeNumber(string1, string2)
{
    let concat = string1 + string2;
    const result = parseInt(concat);
    return result;
}

/**
 * Write a function called addAll that takes an unknown number of parameters
 * and adds all of them together. Return the sum.
 *
 * @param {...number} num a series of numbers to add together
 * @returns {number} the sum of all the parameters (or arguments)
 */

function addAll(...number)
{
    const sum = number.reduce((total, num) => total + num, 0)
    return sum;
}


/*
 * Write and document a function called makeHappy that takes
 * an array and prepends 'Happy ' to the beginning of all the
 * words and returns them as a new array. Use the `map` function.
 */

/**
 * Function that takes a string array and concatenates 
 * the word 'Happy' before each element.
 * 
 * @param {string[]} unhappyArray a series of words that aren't happy
 * @returns {string[]} words preceded with 'Happy '
 */

function makeHappy(unhappyArray)
{
    const happyArray = unhappyArray.map((word) => "Happy " + word);
    return happyArray;
}

/*
 * Write and document a function called getFullAddressesOfProperties
 * that takes an array of JavaScript objects containing the
 * following keys:
 *     * streetNumber
 *     * streetName
 *     * streetType
 *     * city
 *     * state
 *     * zip
 *
 * and returns an array of strings that turns the JavaScript objects
 * into a mailing address in the form of:
 *     streetNumber streetName streetType city state zip
 *
 * Use `map` and an anonymous function.
 */

/**
 * Function that takes in an array containing objects with keys representing parts of a 
 * mailing address, concatenates them together, and returns a new array with a full mailing address.
 * 
 * @param {object[]} objectsContainingPartsOfAddress 
 * @returns an array of strings with a full concatenation of the JS objects, representing a mailing address
 */

function getFullAddressesOfProperties(objectsContainingPartsOfAddress)
{
    const fullAddresses = objectsContainingPartsOfAddress.map((object) => 
    object.streetNumber + " " + object.streetName + " " + object.streetType + " " + 
    object.city + " " + object.state + " " + object.zip)
    
    return fullAddresses;

    // for (let i = 0; i < objectsContainingPartsOfAddress.length; i++)
    // {
    //     let parts = objectsContainingPartsOfAddress[i].values(); 
    // }
}

/*
 * Write and document a function called findLargest.
 *
 * Using `forEach`, find the largest element in an array.
 * It must work for strings and numbers.
 */

/**
 * Function that iterates through an array and returns the largest value.
 * 
 * @param {[]} anArray containing either strings, numbers, or a combination of both
 * @returns the largest value from within the array
 */

function findLargest(anArray)
{
    let largest = '0';
    
    anArray.forEach((element) =>
    {
        if (element > largest)
        {
            largest = element;
        }
    });
    return largest;
}

/*
 * CHALLENGE
 * Write and document a function called getSumOfSubArrayValues.
 *
 * Take an array of arrays, adds up all sub values, and returns
 * the sum. For example, if you got this array as a parameter:
 * [
 *   [1, 2, 3], 6
 *   [2, 4, 6],
 *   [5, 10, 15]
 * ];
 *
 * The function returns 48. To do this, you will use two nested `reduce`
 * calls with two anonymous functions.
 *
 * Read the tests to verify you have the correct behavior.
 */



/**
 * This function takes array of arrays, adds up all the sub values, and returns the sum.
 * 
 * @param {[[]]} arrayOfArrays an array holding multiple arrays containing numbers
 * @returns the sum of all contents of array of arrays
 */

    function getSumOfSubArrayValues(arrayOfArrays = [])
    {
        return mother = arrayOfArrays.reduce((total, subArray) => 
        total + (subArray.reduce((total, num) => 
        total + num, 0)), 0);
    }


// function getSumOfSubArrayValues(arrayOfArrays = 0)
// {
//     let ultimateArray = [];

//     for (let i = 0; i < arrayOfArrays.length; i++)
//     {
//         for (let j = 0; j < arrayOfArrays[i].length; j++)
//         {
//             ultimateArray.push((arrayOfArrays[i])[j])
//         }
//     }

//     const sum = ultimateArray.reduce((previous, current) => previous + current, 0);
//     return sum;
// }
