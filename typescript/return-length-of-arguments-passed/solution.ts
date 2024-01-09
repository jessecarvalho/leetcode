type JSONValue = null | boolean | number | string | JSONValue[] | { [key: string]: JSONValue };

function argumentsLength(...args: JSONValue[]): number {
    let count = 0;
    for (let i = 0; i < args.length; i++) {
        count++
    }
    return count
};