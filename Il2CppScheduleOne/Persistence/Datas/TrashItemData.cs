using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002BC RID: 700
	[Serializable]
	public class TrashItemData : SaveData
	{
		// Token: 0x060031E9 RID: 12777 RVA: 0x0010EA28 File Offset: 0x0010CC28
		// Note: this type is marked as 'beforefieldinit'.
		static TrashItemData()
		{
			Il2CppClassPointerStore<TrashItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr);
			TrashItemData.NativeFieldInfoPtr_TrashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "TrashID");
			TrashItemData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "GUID");
			TrashItemData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "Position");
			TrashItemData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "Rotation");
			TrashItemData.NativeFieldInfoPtr_Contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "Contents");
			TrashItemData.NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, 100668856);
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x0010EAD0 File Offset: 0x0010CCD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131206, RefRangeEnd = 131207, XrefRangeStart = 131203, XrefRangeEnd = 131206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItemData(string trashID, string guid, Vector3 position, Quaternion rotation) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItemData.NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x0001ABD0 File Offset: 0x00018DD0
		public TrashItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x060031EC RID: 12780 RVA: 0x0010EB4C File Offset: 0x0010CD4C
		// (set) Token: 0x060031ED RID: 12781 RVA: 0x0001ABD9 File Offset: 0x00018DD9
		public unsafe string TrashID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_TrashID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_TrashID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x060031EE RID: 12782 RVA: 0x0010EB74 File Offset: 0x0010CD74
		// (set) Token: 0x060031EF RID: 12783 RVA: 0x0001ABF8 File Offset: 0x00018DF8
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x060031F0 RID: 12784 RVA: 0x0010EB9C File Offset: 0x0010CD9C
		// (set) Token: 0x060031F1 RID: 12785 RVA: 0x0001AC17 File Offset: 0x00018E17
		public unsafe Vector3 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x060031F2 RID: 12786 RVA: 0x0010EBC4 File Offset: 0x0010CDC4
		// (set) Token: 0x060031F3 RID: 12787 RVA: 0x0001AC32 File Offset: 0x00018E32
		public unsafe Quaternion Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x060031F4 RID: 12788 RVA: 0x0010EBEC File Offset: 0x0010CDEC
		// (set) Token: 0x060031F5 RID: 12789 RVA: 0x0001AC4D File Offset: 0x00018E4D
		public unsafe TrashContentData Contents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Contents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContentData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Contents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400205E RID: 8286
		private static readonly IntPtr NativeFieldInfoPtr_TrashID;

		// Token: 0x0400205F RID: 8287
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04002060 RID: 8288
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04002061 RID: 8289
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04002062 RID: 8290
		private static readonly IntPtr NativeFieldInfoPtr_Contents;

		// Token: 0x04002063 RID: 8291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_0;
	}
}
