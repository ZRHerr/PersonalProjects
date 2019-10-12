export class Post {

    postId!: number;
    categoryId!: number;
    title!: string;
    description!: string;
    employeeId!: number;
    createdDate!: Date;
    isBookmark?: boolean;
    isLike?: boolean;

}