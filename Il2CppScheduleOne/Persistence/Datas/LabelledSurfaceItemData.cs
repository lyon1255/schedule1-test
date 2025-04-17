using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000299 RID: 665
	public class LabelledSurfaceItemData : SurfaceItemData
	{
		// Token: 0x060030B3 RID: 12467 RVA: 0x0010B1D4 File Offset: 0x001093D4
		// Note: this type is marked as 'beforefieldinit'.
		static LabelledSurfaceItemData()
		{
			Il2CppClassPointerStore<LabelledSurfaceItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "LabelledSurfaceItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabelledSurfaceItemData>.NativeClassPtr);
			LabelledSurfaceItemData.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelledSurfaceItemData>.NativeClassPtr, "Message");
			LabelledSurfaceItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItemData>.NativeClassPtr, 100668814);
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x0010B22C File Offset: 0x0010942C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130917, RefRangeEnd = 130919, XrefRangeStart = 130910, XrefRangeEnd = 130917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabelledSurfaceItemData(Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot, string message) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabelledSurfaceItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x00019F0D File Offset: 0x0001810D
		public LabelledSurfaceItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x060030B6 RID: 12470 RVA: 0x0010B2D8 File Offset: 0x001094D8
		// (set) Token: 0x060030B7 RID: 12471 RVA: 0x00019F16 File Offset: 0x00018116
		public unsafe string Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItemData.NativeFieldInfoPtr_Message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItemData.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001FD1 RID: 8145
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x04001FD2 RID: 8146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_String_0;
	}
}
