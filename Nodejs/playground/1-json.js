const book = {
    name : " thousand",
    published : [1,2,3,4],
    print : function () {
        console.log(this.name)
        this.published.forEach((element) => {
            console.log(element + this.name)
        })
}}
book.print()
// console.log("ih")