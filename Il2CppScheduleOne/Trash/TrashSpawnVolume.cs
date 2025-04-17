using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000525 RID: 1317
	public class TrashSpawnVolume : MonoBehaviour
	{
		// Token: 0x060075D0 RID: 30160 RVA: 0x00201510 File Offset: 0x001FF710
		// Note: this type is marked as 'beforefieldinit'.
		static TrashSpawnVolume()
		{
			Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashSpawnVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr);
			TrashSpawnVolume.NativeFieldInfoPtr_CreatonVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, "CreatonVolume");
			TrashSpawnVolume.NativeFieldInfoPtr_DetectionVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, "DetectionVolume");
			TrashSpawnVolume.NativeFieldInfoPtr_TrashLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, "TrashLimit");
			TrashSpawnVolume.NativeFieldInfoPtr_TrashSpawnChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, "TrashSpawnChance");
			TrashSpawnVolume.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, 100678149);
			TrashSpawnVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, 100678150);
			TrashSpawnVolume.NativeMethodInfoPtr_SleepStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, 100678151);
			TrashSpawnVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, 100678152);
		}

		// Token: 0x060075D1 RID: 30161 RVA: 0x002015E0 File Offset: 0x001FF7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230006, XrefRangeEnd = 230018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashSpawnVolume.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075D2 RID: 30162 RVA: 0x00201614 File Offset: 0x001FF814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230018, XrefRangeEnd = 230032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashSpawnVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075D3 RID: 30163 RVA: 0x00201648 File Offset: 0x001FF848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230032, XrefRangeEnd = 230100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashSpawnVolume.NativeMethodInfoPtr_SleepStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075D4 RID: 30164 RVA: 0x0020167C File Offset: 0x001FF87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230100, XrefRangeEnd = 230101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashSpawnVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashSpawnVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075D5 RID: 30165 RVA: 0x00037C63 File Offset: 0x00035E63
		public TrashSpawnVolume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023AC RID: 9132
		// (get) Token: 0x060075D6 RID: 30166 RVA: 0x002016B8 File Offset: 0x001FF8B8
		// (set) Token: 0x060075D7 RID: 30167 RVA: 0x00037C6C File Offset: 0x00035E6C
		public unsafe BoxCollider CreatonVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_CreatonVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_CreatonVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023AD RID: 9133
		// (get) Token: 0x060075D8 RID: 30168 RVA: 0x002016E8 File Offset: 0x001FF8E8
		// (set) Token: 0x060075D9 RID: 30169 RVA: 0x00037C8B File Offset: 0x00035E8B
		public unsafe BoxCollider DetectionVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_DetectionVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_DetectionVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023AE RID: 9134
		// (get) Token: 0x060075DA RID: 30170 RVA: 0x00201718 File Offset: 0x001FF918
		// (set) Token: 0x060075DB RID: 30171 RVA: 0x00037CAA File Offset: 0x00035EAA
		public unsafe int TrashLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_TrashLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_TrashLimit)) = value;
			}
		}

		// Token: 0x170023AF RID: 9135
		// (get) Token: 0x060075DC RID: 30172 RVA: 0x00201740 File Offset: 0x001FF940
		// (set) Token: 0x060075DD RID: 30173 RVA: 0x00037CC5 File Offset: 0x00035EC5
		public unsafe float TrashSpawnChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_TrashSpawnChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_TrashSpawnChance)) = value;
			}
		}

		// Token: 0x04005089 RID: 20617
		private static readonly IntPtr NativeFieldInfoPtr_CreatonVolume;

		// Token: 0x0400508A RID: 20618
		private static readonly IntPtr NativeFieldInfoPtr_DetectionVolume;

		// Token: 0x0400508B RID: 20619
		private static readonly IntPtr NativeFieldInfoPtr_TrashLimit;

		// Token: 0x0400508C RID: 20620
		private static readonly IntPtr NativeFieldInfoPtr_TrashSpawnChance;

		// Token: 0x0400508D RID: 20621
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x0400508E RID: 20622
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400508F RID: 20623
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Public_Void_0;

		// Token: 0x04005090 RID: 20624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
