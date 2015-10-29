var collection = [],
  len,
  x,
  i,
  min = 1,
  max = 50;

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
