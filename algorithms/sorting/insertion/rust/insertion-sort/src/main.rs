mod insertionsort;
fn main() {
    let numbers = vec![5, 3, 6, 9, 10, 45, 23, 12, 4, 2, -100, 100];
    let numbers1 = vec![5, 3, 6, 9, 10, 45, 23, 12, 4, 2, -100, 100];
    let result = insertionsort::sort(numbers, false);
    let result1 = insertionsort::sort(numbers1, true);
    println!("{:?}", result);
    println!("{:?}", result1);
}
