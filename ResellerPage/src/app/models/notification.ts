import { Country } from './country';
import { Preference } from './preference';

export class Notification {
    private NotificationTitle:string;
    private NotificationBody:string;
    private CountryList: Country[] = [];
    private PreferenceList: Preference[] = [];


    /**
     * Getter $NotificationTitle
     * @return {string}
     */
	public get $NotificationTitle(): string {
		return this.NotificationTitle;
	}

    /**
     * Getter $NotificationBody
     * @return {string}
     */
	public get $NotificationBody(): string {
		return this.NotificationBody;
	}

    /**
     * Getter $CountryList
     * @return {Country[] }
     */
	public get $CountryList(): Country[]  {
		return this.CountryList;
	}

    /**
     * Getter $PreferenceList
     * @return {Preference[] }
     */
	public get $PreferenceList(): Preference[]  {
		return this.PreferenceList;
	}

    /**
     * Setter $NotificationTitle
     * @param {string} value
     */
	public set $NotificationTitle(value: string) {
		this.NotificationTitle = value;
	}

    /**
     * Setter $NotificationBody
     * @param {string} value
     */
	public set $NotificationBody(value: string) {
		this.NotificationBody = value;
	}

    /**
     * Setter $CountryList
     * @param {Country[] } value
     */
	public set $CountryList(value: Country[] ) {
		this.CountryList = value;
	}

    /**
     * Setter $PreferenceList
     * @param {Preference[] } value
     */
	public set $PreferenceList(value: Preference[] ) {
		this.PreferenceList = value;
	}

}
