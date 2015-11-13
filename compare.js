var collection = [],
  len,
  x,
  i,
  min = 1,
  max = 50,
  fs = require('fs');

len = Math.floor(Math.random() * (10));

i = 0;
while(i < len) {
  x = Math.floor(Math.random() * (max - min + 1)) + min;
  compareCollection(x);
  i++;
}

compareCollection(x);

function compareCollection(x) {
  if(collection.indexOf(x) > -1) {
    return;
  }
  else {
    collection.push(x);
    collection.sort(sortArray);
    console.log(collection);
  }

}

function sortArray(a, b) {
    return b - a;
}

fs.appendFile("c:/Logs/compare.log", collection, function(err) {
    if(err) {
        return console.log(err);
    }

    console.log("The file was saved!");
});

fs.appendFile("c:/Logs/ayyyy.log", collection, function(err) {
    if(err) {
        return console.log(err);
    }

    console.log("The file was saved!");
});

fs.appendFile("c:/Logs/test.log", collection, function(err) {
    if(err) {
        return console.log(err);
    }

    console.log("The file was saved!");
});

fs.appendFile("c:/Logs/testingagain.log", collection, function(err) {
    if(err) {
        return console.log(err);
    }

    console.log("The file was saved!");
});

fs.appendFile("c:/Logs/anothertest.log", collection, function(err) {
    if(err) {
        return console.log(err);
    }

    console.log("The file was saved!");
});
