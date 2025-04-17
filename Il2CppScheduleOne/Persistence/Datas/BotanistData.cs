using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200028B RID: 651
	[Serializable]
	public class BotanistData : EmployeeData
	{
		// Token: 0x06003023 RID: 12323 RVA: 0x001096D4 File Offset: 0x001078D4
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistData()
		{
			Il2CppClassPointerStore<BotanistData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BotanistData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistData>.NativeClassPtr);
			BotanistData.NativeFieldInfoPtr_MoveItemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistData>.NativeClassPtr, "MoveItemData");
			BotanistData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_MoveItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistData>.NativeClassPtr, 100668800);
		}

		// Token: 0x06003024 RID: 12324 RVA: 0x0010972C File Offset: 0x0010792C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130822, RefRangeEnd = 130826, XrefRangeStart = 130814, XrefRangeEnd = 130822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistData(string id, string assignedProperty, string firstName, string lastName, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday, MoveItemData moveItemData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistData>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_MoveItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x000198BE File Offset: 0x00017ABE
		public BotanistData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06003026 RID: 12326 RVA: 0x00109818 File Offset: 0x00107A18
		// (set) Token: 0x06003027 RID: 12327 RVA: 0x000198C7 File Offset: 0x00017AC7
		public unsafe MoveItemData MoveItemData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistData.NativeFieldInfoPtr_MoveItemData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveItemData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistData.NativeFieldInfoPtr_MoveItemData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F90 RID: 8080
		private static readonly IntPtr NativeFieldInfoPtr_MoveItemData;

		// Token: 0x04001F91 RID: 8081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_MoveItemData_0;
	}
}
