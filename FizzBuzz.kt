object FizzBuzz {
    @JvmStatic
    fun main(args: Array<String>) {
        val x = 15
        for (i in 1 until x + 1) {
            var resp = ""
            if (i % 3 == 0) {
                resp += "Fizz"
            }
            if (i % 5 == 0) {
                resp += "Buzz"
            }
            if (i % 3 != 0 && i % 5 != 0) {
                resp = i.toString()
            }
            println(resp)
        }
    }
}
