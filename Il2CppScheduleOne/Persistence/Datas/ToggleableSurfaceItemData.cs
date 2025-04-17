using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A4 RID: 676
	public class ToggleableSurfaceItemData : SurfaceItemData
	{
		// Token: 0x0600310E RID: 12558 RVA: 0x0010C414 File Offset: 0x0010A614
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleableSurfaceItemData()
		{
			Il2CppClassPointerStore<ToggleableSurfaceItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ToggleableSurfaceItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleableSurfaceItemData>.NativeClassPtr);
			ToggleableSurfaceItemData.NativeFieldInfoPtr_IsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableSurfaceItemData>.NativeClassPtr, "IsOn");
			ToggleableSurfaceItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItemData>.NativeClassPtr, 100668825);
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x0010C46C File Offset: 0x0010A66C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130977, RefRangeEnd = 130978, XrefRangeStart = 130972, XrefRangeEnd = 130977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleableSurfaceItemData(Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot, bool isOn) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleableSurfaceItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x0001A2C7 File Offset: 0x000184C7
		public ToggleableSurfaceItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06003111 RID: 12561 RVA: 0x0010C510 File Offset: 0x0010A710
		// (set) Token: 0x06003112 RID: 12562 RVA: 0x0001A2D0 File Offset: 0x000184D0
		public unsafe bool IsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItemData.NativeFieldInfoPtr_IsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItemData.NativeFieldInfoPtr_IsOn)) = value;
			}
		}

		// Token: 0x04001FF9 RID: 8185
		private static readonly IntPtr NativeFieldInfoPtr_IsOn;

		// Token: 0x04001FFA RID: 8186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_Boolean_0;
	}
}
