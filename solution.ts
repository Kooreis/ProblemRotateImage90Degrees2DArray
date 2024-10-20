Here is a TypeScript solution for rotating a 2D array (image) by 90 degrees:

```typescript
class ImageRotator {
    rotateImage(image: number[][]): number[][] {
        let n = image.length;
        let rotatedImage = Array.from(Array(n), () => new Array(n).fill(0));

        for (let i = 0; i < n; i++) {
            for (let j = 0; j < n; j++) {
                rotatedImage[j][n - 1 - i] = image[i][j];
            }
        }

        return rotatedImage;
    }
}

let imageRotator = new ImageRotator();
let image = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
let rotatedImage = imageRotator.rotateImage(image);

console.log(rotatedImage);
```

This code defines a class `ImageRotator` with a method `rotateImage` that takes a 2D array (image) as input and returns a new 2D array which is the original image rotated by 90 degrees. The rotation is done by swapping the rows and columns of the image in a certain way. The rotated image is then printed to the console.