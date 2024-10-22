for (let i = 0; i < x; i++) {
        for (let j = i; j < y - i; j++) {
            let k = image[i][j];
            image[i][j] = image[y - j][i];
            image[y - j][i] = image[y - i][y - j];
            image[y - i][y - j] = image[j][y - i]
            image[j][y - i] = k
        }
    }