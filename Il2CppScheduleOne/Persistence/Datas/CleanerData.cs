﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200028D RID: 653
	[Serializable]
	public class CleanerData : EmployeeData
	{
		// Token: 0x0600302D RID: 12333 RVA: 0x001099BC File Offset: 0x00107BBC
		// Note: this type is marked as 'beforefieldinit'.
		static CleanerData()
		{
			Il2CppClassPointerStore<CleanerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CleanerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerData>.NativeClassPtr);
			CleanerData.NativeFieldInfoPtr_MoveItemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerData>.NativeClassPtr, "MoveItemData");
			CleanerData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_MoveItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerData>.NativeClassPtr, 100668802);
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x00109A14 File Offset: 0x00107C14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130822, RefRangeEnd = 130826, XrefRangeStart = 130822, XrefRangeEnd = 130826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanerData(string id, string assignedProperty, string firstName, string lastName, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday, MoveItemData moveItemData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerData>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_MoveItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x0001990E File Offset: 0x00017B0E
		public CleanerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x06003030 RID: 12336 RVA: 0x00109B00 File Offset: 0x00107D00
		// (set) Token: 0x06003031 RID: 12337 RVA: 0x00019917 File Offset: 0x00017B17
		public unsafe MoveItemData MoveItemData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerData.NativeFieldInfoPtr_MoveItemData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveItemData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerData.NativeFieldInfoPtr_MoveItemData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F94 RID: 8084
		private static readonly IntPtr NativeFieldInfoPtr_MoveItemData;

		// Token: 0x04001F95 RID: 8085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_MoveItemData_0;
	}
}
