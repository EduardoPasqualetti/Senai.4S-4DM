export function getRightDate(object){
    let now = new Date();
    return now.toLocaleDateString('default',object)
}


export function capitalizeFirstLetter(string) {
    return string.charAt(0).toUpperCase() + string.slice(1);
}