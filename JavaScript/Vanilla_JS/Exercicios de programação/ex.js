var isPalindrome = function (x) {
    let msg = true;
    let str = (x.toString().split("").reverse().join("")) * 1
    if (x != str){
        msg = false
        return msg
    }
    
    const result = console.log(msg)
    return result
};


isPalindrome(657)