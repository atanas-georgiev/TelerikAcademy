//  Problem 1. Increase array members
//
//  Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//  Print the obtained array on the console.

function problem01_IncreaseArrayMembers() {

    var index = 0,
        result = new Array(20);

    for (index = 0; index < 20; index++) {
        result[index] = index * 5;
    }

    console.log(result);

}