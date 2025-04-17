using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000265 RID: 613
	[Serializable]
	public class IntegerItemData : ItemData
	{
		// Token: 0x06002F27 RID: 12071 RVA: 0x00106D90 File Offset: 0x00104F90
		// Note: this type is marked as 'beforefieldinit'.
		static IntegerItemData()
		{
			Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "IntegerItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr);
			IntegerItemData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr, "Value");
			IntegerItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr, 100668760);
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x00106DE8 File Offset: 0x00104FE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130592, RefRangeEnd = 130594, XrefRangeStart = 130592, XrefRangeEnd = 130594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemData(string iD, int quantity, int value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x00018EDD File Offset: 0x000170DD
		public IntegerItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06002F2A RID: 12074 RVA: 0x00106E50 File Offset: 0x00105050
		// (set) Token: 0x06002F2B RID: 12075 RVA: 0x00018EE6 File Offset: 0x000170E6
		public unsafe int Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemData.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemData.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x04001F24 RID: 7972
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001F25 RID: 7973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0;
	}
}
