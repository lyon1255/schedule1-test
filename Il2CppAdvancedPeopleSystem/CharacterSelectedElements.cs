using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x0200015B RID: 347
	[Serializable]
	public class CharacterSelectedElements : Object
	{
		// Token: 0x06001C2E RID: 7214 RVA: 0x000C7FE4 File Offset: 0x000C61E4
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterSelectedElements()
		{
			Il2CppClassPointerStore<CharacterSelectedElements>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterSelectedElements");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSelectedElements>.NativeClassPtr);
			CharacterSelectedElements.NativeFieldInfoPtr_Hair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSelectedElements>.NativeClassPtr, "Hair");
			CharacterSelectedElements.NativeFieldInfoPtr_Beard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSelectedElements>.NativeClassPtr, "Beard");
			CharacterSelectedElements.NativeFieldInfoPtr_Hat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSelectedElements>.NativeClassPtr, "Hat");
			CharacterSelectedElements.NativeFieldInfoPtr_Shirt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSelectedElements>.NativeClassPtr, "Shirt");
			CharacterSelectedElements.NativeFieldInfoPtr_Pants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSelectedElements>.NativeClassPtr, "Pants");
			CharacterSelectedElements.NativeFieldInfoPtr_Shoes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSelectedElements>.NativeClassPtr, "Shoes");
			CharacterSelectedElements.NativeFieldInfoPtr_Accessory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSelectedElements>.NativeClassPtr, "Accessory");
			CharacterSelectedElements.NativeFieldInfoPtr_Item1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSelectedElements>.NativeClassPtr, "Item1");
			CharacterSelectedElements.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSelectedElements>.NativeClassPtr, 100666243);
			CharacterSelectedElements.NativeMethodInfoPtr_GetSelectedIndex_Public_Int32_CharacterElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSelectedElements>.NativeClassPtr, 100666244);
			CharacterSelectedElements.NativeMethodInfoPtr_SetSelectedIndex_Public_Void_CharacterElementType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSelectedElements>.NativeClassPtr, 100666245);
			CharacterSelectedElements.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSelectedElements>.NativeClassPtr, 100666246);
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x000C8104 File Offset: 0x000C6304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100611, RefRangeEnd = 100612, XrefRangeStart = 100607, XrefRangeEnd = 100611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSelectedElements.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x000C8144 File Offset: 0x000C6344
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 100612, RefRangeEnd = 100621, XrefRangeStart = 100612, XrefRangeEnd = 100612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSelectedIndex(CharacterElementType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSelectedElements.NativeMethodInfoPtr_GetSelectedIndex_Public_Int32_CharacterElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x000C8190 File Offset: 0x000C6390
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 100621, RefRangeEnd = 100624, XrefRangeStart = 100621, XrefRangeEnd = 100621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedIndex(CharacterElementType type, int newIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSelectedElements.NativeMethodInfoPtr_SetSelectedIndex_Public_Void_CharacterElementType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x000C81DC File Offset: 0x000C63DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100625, RefRangeEnd = 100627, XrefRangeStart = 100624, XrefRangeEnd = 100625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterSelectedElements() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterSelectedElements>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSelectedElements.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x000100D2 File Offset: 0x0000E2D2
		public CharacterSelectedElements(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x000C8218 File Offset: 0x000C6418
		// (set) Token: 0x06001C35 RID: 7221 RVA: 0x000100DB File Offset: 0x0000E2DB
		public unsafe int Hair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSelectedElements.NativeFieldInfoPtr_Hair);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSelectedElements.NativeFieldInfoPtr_Hair)) = value;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x000C8240 File Offset: 0x000C6440
		// (set) Token: 0x06001C37 RID: 7223 RVA: 0x000100F6 File Offset: 0x0000E2F6
		public unsafe int Beard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSelectedElements.NativeFieldInfoPtr_Beard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSelectedElements.NativeFieldInfoPtr_Beard)) = value;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001C38 RID: 7224 RVA: 0x000C8268 File Offset: 0x000C6468
		// (set) Token: 0x06001C39 RID: 7225 RVA: 0x00010111 File Offset: 0x0000E311
		public unsafe int Hat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSelectedElements.NativeFieldInfoPtr_Hat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSelectedElements.NativeFieldInfoPtr_Hat)) = value;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001C3A RID: 7226 RVA: 0x000C8290 File Offset: 0x000C6490
		// (set) Token: 0x06001C3B RID: 7227 RVA: 0x0001012C File Offset: 0x0000E32C
		public unsafe int Shirt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSelectedElements.NativeFieldInfoPtr_Shirt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSelectedElements.NativeFieldInfoPtr_Shirt)) = value;
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06001C3C RID: 7228 RVA: 0x000C82B8 File Offset: 0x000C64B8
		// (set) Token: 0x06001C3D RID: 7229 RVA: 0x00010147 File Offset: 0x0000E347
		public unsafe int Pants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSelectedElements.NativeFieldInfoPtr_Pants);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSelectedElements.NativeFieldInfoPtr_Pants)) = value;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06001C3E RID: 7230 RVA: 0x000C82E0 File Offset: 0x000C64E0
		// (set) Token: 0x06001C3F RID: 7231 RVA: 0x00010162 File Offset: 0x0000E362
		public unsafe int Shoes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSelectedElements.NativeFieldInfoPtr_Shoes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSelectedElements.NativeFieldInfoPtr_Shoes)) = value;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x000C8308 File Offset: 0x000C6508
		// (set) Token: 0x06001C41 RID: 7233 RVA: 0x0001017D File Offset: 0x0000E37D
		public unsafe int Accessory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSelectedElements.NativeFieldInfoPtr_Accessory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSelectedElements.NativeFieldInfoPtr_Accessory)) = value;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x000C8330 File Offset: 0x000C6530
		// (set) Token: 0x06001C43 RID: 7235 RVA: 0x00010198 File Offset: 0x0000E398
		public unsafe int Item1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSelectedElements.NativeFieldInfoPtr_Item1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSelectedElements.NativeFieldInfoPtr_Item1)) = value;
			}
		}

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeFieldInfoPtr_Hair;

		// Token: 0x04001275 RID: 4725
		private static readonly IntPtr NativeFieldInfoPtr_Beard;

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeFieldInfoPtr_Hat;

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeFieldInfoPtr_Shirt;

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeFieldInfoPtr_Pants;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeFieldInfoPtr_Shoes;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeFieldInfoPtr_Accessory;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeFieldInfoPtr_Item1;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectedIndex_Public_Int32_CharacterElementType_0;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedIndex_Public_Void_CharacterElementType_Int32_0;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
