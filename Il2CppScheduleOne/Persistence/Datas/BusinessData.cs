using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200025A RID: 602
	[Serializable]
	public class BusinessData : PropertyData
	{
		// Token: 0x06002EB2 RID: 11954 RVA: 0x00105894 File Offset: 0x00103A94
		// Note: this type is marked as 'beforefieldinit'.
		static BusinessData()
		{
			Il2CppClassPointerStore<BusinessData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BusinessData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BusinessData>.NativeClassPtr);
			BusinessData.NativeFieldInfoPtr_LaunderingOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BusinessData>.NativeClassPtr, "LaunderingOperations");
			BusinessData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_LaunderOperationData_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessData>.NativeClassPtr, 100668725);
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x001058EC File Offset: 0x00103AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130402, RefRangeEnd = 130403, XrefRangeStart = 130397, XrefRangeEnd = 130402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BusinessData(string propertyCode, bool isOwned, Il2CppStructArray<bool> switchStates, Il2CppReferenceArray<LaunderOperationData> launderingOperations, Il2CppStructArray<bool> toggleableStates) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BusinessData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOwned;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(switchStates);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(launderingOperations);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toggleableStates);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_LaunderOperationData_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x00018A41 File Offset: 0x00016C41
		public BusinessData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06002EB5 RID: 11957 RVA: 0x00105980 File Offset: 0x00103B80
		// (set) Token: 0x06002EB6 RID: 11958 RVA: 0x00018A4A File Offset: 0x00016C4A
		public unsafe Il2CppReferenceArray<LaunderOperationData> LaunderingOperations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BusinessData.NativeFieldInfoPtr_LaunderingOperations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LaunderOperationData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BusinessData.NativeFieldInfoPtr_LaunderingOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001EE9 RID: 7913
		private static readonly IntPtr NativeFieldInfoPtr_LaunderingOperations;

		// Token: 0x04001EEA RID: 7914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_LaunderOperationData_Il2CppStructArray_1_Boolean_0;
	}
}
