const sum = require('../index');


describe(`Sum function`, () => {
    test(`adds 1 + 2 to equal 3`, () => {
        expect(sum(1, 2)).toBe(3);
      });

    test(`adds 15 + 20 to equal 35`, () => {
        expect(sum(15, 20)).toBe(35);
      });
});
