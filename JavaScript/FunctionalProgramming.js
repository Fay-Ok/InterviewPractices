function waysOfManipulatingArray() {

    let arrOfSubject = [
        { id: 1, name: "Foo" },
        { id: 2, name: "Boo" },
        { id: 3, name: "Soo" }
    ];

    let arrOfname = arrOfSubject.map(function (item) {
        return item.name;
    })

    let arrOfname1 = arrOfSubject.map(item => {
        return item.name;
    });

    let arr = [1, 2, 34];
    let getIndex = arr.map((value, index, array) => {
        return index + 2;
    });
    console.log("Map examples-------------");
    console.log(arrOfname);
    console.log(arrOfname1);
    console.log(getIndex);

    // filter
    var strings = ["mad", "sad", "powerfull", "lost"];
    var stringsWitAd = strings.filter((item) => {
        return item.indexOf("sd") > -1;
    })
    console.log("Filter example---------");
    console.log("stringsWitAd");

    // reduce

    const mult = ["songs", [{id: 112, name: "Chop Suey", artist: "System of a Down" }]];
    var newMult = mult.reduce((newArray, currEmlement) => {
        return newArray.concat(currEmlement);
    },[]);
    
    console.log("Reduce example--------");
    console.log(newMult);
};

waysOfManipulatingArray();