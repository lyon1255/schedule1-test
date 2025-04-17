using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000524 RID: 1316
	public class TrashRemovalVolume : MonoBehaviour
	{
		// Token: 0x060075C5 RID: 30149 RVA: 0x002012E4 File Offset: 0x001FF4E4
		// Note: this type is marked as 'beforefieldinit'.
		static TrashRemovalVolume()
		{
			Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashRemovalVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr);
			TrashRemovalVolume.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, "Collider");
			TrashRemovalVolume.NativeFieldInfoPtr_RemovalChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, "RemovalChance");
			TrashRemovalVolume.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100678144);
			TrashRemovalVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100678145);
			TrashRemovalVolume.NativeMethodInfoPtr_SleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100678146);
			TrashRemovalVolume.NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100678147);
			TrashRemovalVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100678148);
		}

		// Token: 0x060075C6 RID: 30150 RVA: 0x002013A0 File Offset: 0x001FF5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229936, XrefRangeEnd = 229948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075C7 RID: 30151 RVA: 0x002013D4 File Offset: 0x001FF5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229948, XrefRangeEnd = 229962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075C8 RID: 30152 RVA: 0x00201408 File Offset: 0x001FF608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229962, XrefRangeEnd = 229967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr_SleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075C9 RID: 30153 RVA: 0x0020143C File Offset: 0x001FF63C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230004, RefRangeEnd = 230005, XrefRangeStart = 229967, XrefRangeEnd = 230004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TrashItem> GetTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashItem>>(intPtr3) : null;
		}

		// Token: 0x060075CA RID: 30154 RVA: 0x0020147C File Offset: 0x001FF67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230005, XrefRangeEnd = 230006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashRemovalVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075CB RID: 30155 RVA: 0x00037C20 File Offset: 0x00035E20
		public TrashRemovalVolume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023AA RID: 9130
		// (get) Token: 0x060075CC RID: 30156 RVA: 0x002014B8 File Offset: 0x001FF6B8
		// (set) Token: 0x060075CD RID: 30157 RVA: 0x00037C29 File Offset: 0x00035E29
		public unsafe BoxCollider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashRemovalVolume.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashRemovalVolume.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023AB RID: 9131
		// (get) Token: 0x060075CE RID: 30158 RVA: 0x002014E8 File Offset: 0x001FF6E8
		// (set) Token: 0x060075CF RID: 30159 RVA: 0x00037C48 File Offset: 0x00035E48
		public unsafe float RemovalChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashRemovalVolume.NativeFieldInfoPtr_RemovalChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashRemovalVolume.NativeFieldInfoPtr_RemovalChance)) = value;
			}
		}

		// Token: 0x04005082 RID: 20610
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04005083 RID: 20611
		private static readonly IntPtr NativeFieldInfoPtr_RemovalChance;

		// Token: 0x04005084 RID: 20612
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04005085 RID: 20613
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005086 RID: 20614
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Private_Void_0;

		// Token: 0x04005087 RID: 20615
		private static readonly IntPtr NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0;

		// Token: 0x04005088 RID: 20616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
