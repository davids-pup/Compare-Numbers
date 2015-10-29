/* global describe:true, before:true, after:true, it:true, global:true, process:true */

var compare = require('./compare.js'),
  expect = require('chai').expect,
  collection = [];

describe('Compare Spec', function () {

  beforeEach(function () {
		collection = [];
	});

  context('when array has length 0', function () {
    it('should do nothing and return array', function () {
      collection = compare.compareCollection(collection);
      expect(collection).to.equal([]);
    });
  });

  context('when array has length 1', function () {
    it('should do nothing and return array', function () {
      collection.push(2);
      collection = compare.compareCollection(collection);
      expect(collection).to.equal([2]);
    });
  });

  context('when array has strings instead of integers', function () {
    it('should output error', function () {
      collection.push("hello");
      collection.push("batman");
      collection.push("goodbye");
      collection = compare.compareCollection(collection);

    });
  });

  context('when array has length greater than one and filled with integers', function () {
    it('should sort array in ascending order', function () {
      collection.push(2);
      collection.push(7);
      collection.push(28);
      collection.push(14);
      collection.push(37);
      collection = compare.compareCollection(collection);
      expect(collection).to.equal([37, 28, 14, 7, 2]);
    });
  });
});
