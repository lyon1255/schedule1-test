using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000291 RID: 657
	[Serializable]
	public class PackagerData : EmployeeData
	{
		// Token: 0x06003061 RID: 12385 RVA: 0x0010A288 File Offset: 0x00108488
		// Note: this type is marked as 'beforefieldinit'.
		static PackagerData()
		{
			Il2CppClassPointerStore<PackagerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PackagerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerData>.NativeClassPtr);
			PackagerData.NativeFieldInfoPtr_MoveItemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerData>.NativeClassPtr, "MoveItemData");
			PackagerData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_MoveItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerData>.NativeClassPtr, 100668806);
		}

		// Token: 0x06003062 RID: 12386 RVA: 0x0010A2E0 File Offset: 0x001084E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130822, RefRangeEnd = 130826, XrefRangeStart = 130822, XrefRangeEnd = 130826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagerData(string id, string assignedProperty, string firstName, string lastName, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday, MoveItemData moveItemData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerData>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_MoveItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x00019B7A File Offset: 0x00017D7A
		public PackagerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x0010A3CC File Offset: 0x001085CC
		// (set) Token: 0x06003065 RID: 12389 RVA: 0x00019B83 File Offset: 0x00017D83
		public unsafe MoveItemData MoveItemData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerData.NativeFieldInfoPtr_MoveItemData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveItemData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerData.NativeFieldInfoPtr_MoveItemData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FAC RID: 8108
		private static readonly IntPtr NativeFieldInfoPtr_MoveItemData;

		// Token: 0x04001FAD RID: 8109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_MoveItemData_0;
	}
}
