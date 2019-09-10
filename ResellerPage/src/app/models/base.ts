export class Base {

    /**
     * Getter $id
     * @return {number}
     */
	public get $id(): number {
		return this.id;
	}

    /**
     * Setter $id
     * @param {number} value
     */
	public set $id(value: number) {
		this.id = value;
	}
    private id: number;


	constructor(data?) {
        if(data){
        this.id = data.Id || 0;
        }
	}



}
