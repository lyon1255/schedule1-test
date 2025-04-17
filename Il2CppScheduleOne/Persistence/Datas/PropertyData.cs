using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002AE RID: 686
	[Serializable]
	public class PropertyData : SaveData
	{
		// Token: 0x06003163 RID: 12643 RVA: 0x0010D360 File Offset: 0x0010B560
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyData()
		{
			Il2CppClassPointerStore<PropertyData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PropertyData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyData>.NativeClassPtr);
			PropertyData.NativeFieldInfoPtr_PropertyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "PropertyCode");
			PropertyData.NativeFieldInfoPtr_IsOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "IsOwned");
			PropertyData.NativeFieldInfoPtr_SwitchStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "SwitchStates");
			PropertyData.NativeFieldInfoPtr_ToggleableStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "ToggleableStates");
			PropertyData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, 100668836);
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x0010D3F4 File Offset: 0x0010B5F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131020, RefRangeEnd = 131021, XrefRangeStart = 131016, XrefRangeEnd = 131020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyData(string propertyCode, bool isOwned, Il2CppStructArray<bool> switchStates, Il2CppStructArray<bool> toggleableStates) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOwned;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(switchStates);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toggleableStates);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x0001A63E File Offset: 0x0001883E
		public PropertyData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06003166 RID: 12646 RVA: 0x0010D474 File Offset: 0x0010B674
		// (set) Token: 0x06003167 RID: 12647 RVA: 0x0001A647 File Offset: 0x00018847
		public unsafe string PropertyCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_PropertyCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_PropertyCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x06003168 RID: 12648 RVA: 0x0010D49C File Offset: 0x0010B69C
		// (set) Token: 0x06003169 RID: 12649 RVA: 0x0001A666 File Offset: 0x00018866
		public unsafe bool IsOwned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_IsOwned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_IsOwned)) = value;
			}
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x0600316A RID: 12650 RVA: 0x0010D4C4 File Offset: 0x0010B6C4
		// (set) Token: 0x0600316B RID: 12651 RVA: 0x0001A681 File Offset: 0x00018881
		public unsafe Il2CppStructArray<bool> SwitchStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_SwitchStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_SwitchStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x0600316C RID: 12652 RVA: 0x0010D4F4 File Offset: 0x0010B6F4
		// (set) Token: 0x0600316D RID: 12653 RVA: 0x0001A6A0 File Offset: 0x000188A0
		public unsafe Il2CppStructArray<bool> ToggleableStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_ToggleableStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_ToggleableStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400201F RID: 8223
		private static readonly IntPtr NativeFieldInfoPtr_PropertyCode;

		// Token: 0x04002020 RID: 8224
		private static readonly IntPtr NativeFieldInfoPtr_IsOwned;

		// Token: 0x04002021 RID: 8225
		private static readonly IntPtr NativeFieldInfoPtr_SwitchStates;

		// Token: 0x04002022 RID: 8226
		private static readonly IntPtr NativeFieldInfoPtr_ToggleableStates;

		// Token: 0x04002023 RID: 8227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_0;
	}
}
