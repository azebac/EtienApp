export class Base {

    /**
     * Getter $id
     * @return {number}
     */
	public get $id(): number {
		return this.Id;
	}

    /**
     * Setter $id
     * @param {number} value
     */
	public set $id(value: number) {
		this.Id = value;
	}
    private Id: number;


	constructor(data?) {
        if(data){
        this.Id = data.Id || 0;
        }
	}



}
