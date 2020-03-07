pub fn sort(numbers: Vec<i32>, reversed: bool) -> Vec<i32> {
    let mut result = numbers;
    for i in 1..result.len() {
        let key = result[i];
        let mut j: i32 = i as i32 - 1;
        while (!reversed && j >= 0 && key < result[j as usize])
            || (reversed && j >= 0 && key > result[j as usize])
        {
            result[(j + 1) as usize] = result[j as usize];
            j -= 1;
        }
        result[(j + 1) as usize] = key;
    }
    return result;
}
