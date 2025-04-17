using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006E7 RID: 1767
	public class MainMenuPopup : Singleton<MainMenuPopup>
	{
		// Token: 0x06009E45 RID: 40517 RVA: 0x0027FE5C File Offset: 0x0027E05C
		// Note: this type is marked as 'beforefieldinit'.
		static MainMenuPopup()
		{
			Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "MainMenuPopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr);
			MainMenuPopup.NativeFieldInfoPtr_Screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, "Screen");
			MainMenuPopup.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, "Title");
			MainMenuPopup.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, "Description");
			MainMenuPopup.NativeMethodInfoPtr_Open_Public_Void_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, 100682717);
			MainMenuPopup.NativeMethodInfoPtr_Open_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, 100682718);
			MainMenuPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, 100682719);
		}

		// Token: 0x06009E46 RID: 40518 RVA: 0x0027FF04 File Offset: 0x0027E104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279916, RefRangeEnd = 279917, XrefRangeStart = 279914, XrefRangeEnd = 279916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(MainMenuPopup.Data data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPopup.NativeMethodInfoPtr_Open_Public_Void_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E47 RID: 40519 RVA: 0x0027FF48 File Offset: 0x0027E148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279919, RefRangeEnd = 279920, XrefRangeStart = 279917, XrefRangeEnd = 279919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string title, string description, bool isBad)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBad;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPopup.NativeMethodInfoPtr_Open_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E48 RID: 40520 RVA: 0x0027FFAC File Offset: 0x0027E1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279920, XrefRangeEnd = 279923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MainMenuPopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E49 RID: 40521 RVA: 0x0004D9E4 File Offset: 0x0004BBE4
		public MainMenuPopup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030B8 RID: 12472
		// (get) Token: 0x06009E4A RID: 40522 RVA: 0x0027FFE8 File Offset: 0x0027E1E8
		// (set) Token: 0x06009E4B RID: 40523 RVA: 0x0004D9ED File Offset: 0x0004BBED
		public unsafe MainMenuScreen Screen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Screen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenuScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Screen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030B9 RID: 12473
		// (get) Token: 0x06009E4C RID: 40524 RVA: 0x00280018 File Offset: 0x0027E218
		// (set) Token: 0x06009E4D RID: 40525 RVA: 0x0004DA0C File Offset: 0x0004BC0C
		public unsafe TextMeshProUGUI Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030BA RID: 12474
		// (get) Token: 0x06009E4E RID: 40526 RVA: 0x00280048 File Offset: 0x0027E248
		// (set) Token: 0x06009E4F RID: 40527 RVA: 0x0004DA2B File Offset: 0x0004BC2B
		public unsafe TextMeshProUGUI Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Description);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Description), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A3D RID: 27197
		private static readonly IntPtr NativeFieldInfoPtr_Screen;

		// Token: 0x04006A3E RID: 27198
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04006A3F RID: 27199
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x04006A40 RID: 27200
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_Data_0;

		// Token: 0x04006A41 RID: 27201
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_String_String_Boolean_0;

		// Token: 0x04006A42 RID: 27202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B9B RID: 2971
		public class Data : Object
		{
			// Token: 0x0600DC5A RID: 56410 RVA: 0x00341B3C File Offset: 0x0033FD3C
			// Note: this type is marked as 'beforefieldinit'.
			static Data()
			{
				Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, "Data");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr);
				MainMenuPopup.Data.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr, "Title");
				MainMenuPopup.Data.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr, "Description");
				MainMenuPopup.Data.NativeFieldInfoPtr_IsBad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr, "IsBad");
				MainMenuPopup.Data.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr, 100682720);
			}

			// Token: 0x0600DC5B RID: 56411 RVA: 0x00341BB8 File Offset: 0x0033FDB8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 279913, RefRangeEnd = 279914, XrefRangeStart = 279910, XrefRangeEnd = 279913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Data(string title, string description, bool isBad) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBad;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPopup.Data.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC5C RID: 56412 RVA: 0x0006B56D File Offset: 0x0006976D
			public Data(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700444B RID: 17483
			// (get) Token: 0x0600DC5D RID: 56413 RVA: 0x00341C24 File Offset: 0x0033FE24
			// (set) Token: 0x0600DC5E RID: 56414 RVA: 0x0006B576 File Offset: 0x00069776
			public unsafe string Title
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_Title);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700444C RID: 17484
			// (get) Token: 0x0600DC5F RID: 56415 RVA: 0x00341C4C File Offset: 0x0033FE4C
			// (set) Token: 0x0600DC60 RID: 56416 RVA: 0x0006B595 File Offset: 0x00069795
			public unsafe string Description
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_Description);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700444D RID: 17485
			// (get) Token: 0x0600DC61 RID: 56417 RVA: 0x00341C74 File Offset: 0x0033FE74
			// (set) Token: 0x0600DC62 RID: 56418 RVA: 0x0006B5B4 File Offset: 0x000697B4
			public unsafe bool IsBad
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_IsBad);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_IsBad)) = value;
				}
			}

			// Token: 0x040093AC RID: 37804
			private static readonly IntPtr NativeFieldInfoPtr_Title;

			// Token: 0x040093AD RID: 37805
			private static readonly IntPtr NativeFieldInfoPtr_Description;

			// Token: 0x040093AE RID: 37806
			private static readonly IntPtr NativeFieldInfoPtr_IsBad;

			// Token: 0x040093AF RID: 37807
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0;
		}
	}
}
