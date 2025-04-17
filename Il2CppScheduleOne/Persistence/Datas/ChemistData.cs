using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200028C RID: 652
	[Serializable]
	public class ChemistData : EmployeeData
	{
		// Token: 0x06003028 RID: 12328 RVA: 0x00109848 File Offset: 0x00107A48
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistData()
		{
			Il2CppClassPointerStore<ChemistData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ChemistData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistData>.NativeClassPtr);
			ChemistData.NativeFieldInfoPtr_MoveItemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistData>.NativeClassPtr, "MoveItemData");
			ChemistData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_MoveItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistData>.NativeClassPtr, 100668801);
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x001098A0 File Offset: 0x00107AA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130822, RefRangeEnd = 130826, XrefRangeStart = 130822, XrefRangeEnd = 130826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistData(string id, string assignedProperty, string firstName, string lastName, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday, MoveItemData moveItemData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assignedProperty);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guid;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paidForToday;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(moveItemData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_MoveItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600302A RID: 12330 RVA: 0x000198E6 File Offset: 0x00017AE6
		public ChemistData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x0600302B RID: 12331 RVA: 0x0010998C File Offset: 0x00107B8C
		// (set) Token: 0x0600302C RID: 12332 RVA: 0x000198EF File Offset: 0x00017AEF
		public unsafe MoveItemData MoveItemData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistData.NativeFieldInfoPtr_MoveItemData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveItemData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistData.NativeFieldInfoPtr_MoveItemData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F92 RID: 8082
		private static readonly IntPtr NativeFieldInfoPtr_MoveItemData;

		// Token: 0x04001F93 RID: 8083
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_MoveItemData_0;
	}
}
