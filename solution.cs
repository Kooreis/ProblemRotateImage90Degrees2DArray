Here is a JavaScript solution for rotating a 2D array (image) by 90 degrees:

```javascript
function rotateImage(image) {
    const n = image.length;
    const x = Math.floor(n/ 2);
    const y = n - 1;
    for (let i = 0; i < x; i++) {
        for (let j = i; j < y - i; j++) {
            let k = image[i][j];
            image[i][j] = image[y - j][i];
            image[y - j][i] = image[y - i][y - j];
            image[y - i][y - j] = image[j][y - i]
            image[j][y - i] = k
        }
    }
    return image;
}

const image = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
];

console.log(rotateImage(image));
```

This script defines a function `rotateImage` that takes a 2D array `image` as input and rotates it 90 degrees. The rotated image is then returned. The script then defines a 2D array `image` and calls `rotateImage` with `image` as argument, printing the result to the console.