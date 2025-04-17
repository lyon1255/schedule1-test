﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000266 RID: 614
	[Serializable]
	public class ItemData : SaveData
	{
		// Token: 0x06002F2C RID: 12076 RVA: 0x00106E78 File Offset: 0x00105078
		// Note: this type is marked as 'beforefieldinit'.
		static ItemData()
		{
			Il2CppClassPointerStore<ItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemData>.NativeClassPtr);
			ItemData.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "ID");
			ItemData.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "Quantity");
			ItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100668761);
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x00106EE4 File Offset: 0x001050E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 130604, RefRangeEnd = 130609, XrefRangeStart = 130602, XrefRangeEnd = 130604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemData(string iD, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x00018F01 File Offset: 0x00017101
		public ItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06002F2F RID: 12079 RVA: 0x00106F40 File Offset: 0x00105140
		// (set) Token: 0x06002F30 RID: 12080 RVA: 0x00018F0A File Offset: 0x0001710A
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemData.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemData.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06002F31 RID: 12081 RVA: 0x00106F68 File Offset: 0x00105168
		// (set) Token: 0x06002F32 RID: 12082 RVA: 0x00018F29 File Offset: 0x00017129
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemData.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemData.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x04001F26 RID: 7974
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04001F27 RID: 7975
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x04001F28 RID: 7976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
	}
}
