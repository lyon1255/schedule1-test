using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x0200077D RID: 1917
	public class MedicalCentre : NPCEnterableBuilding
	{
		// Token: 0x0600B59B RID: 46491 RVA: 0x002D23BC File Offset: 0x002D05BC
		// Note: this type is marked as 'beforefieldinit'.
		static MedicalCentre()
		{
			Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "MedicalCentre");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr);
			MedicalCentre.NativeFieldInfoPtr_RespawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr, "RespawnPoint");
			MedicalCentre.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr, 100685617);
		}

		// Token: 0x0600B59C RID: 46492 RVA: 0x002D2414 File Offset: 0x002D0614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310131, XrefRangeEnd = 310132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MedicalCentre() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MedicalCentre.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B59D RID: 46493 RVA: 0x00059242 File Offset: 0x00057442
		public MedicalCentre(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700384D RID: 14413
		// (get) Token: 0x0600B59E RID: 46494 RVA: 0x002D2450 File Offset: 0x002D0650
		// (set) Token: 0x0600B59F RID: 46495 RVA: 0x0005924B File Offset: 0x0005744B
		public unsafe Transform RespawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MedicalCentre.NativeFieldInfoPtr_RespawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MedicalCentre.NativeFieldInfoPtr_RespawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A60 RID: 31328
		private static readonly IntPtr NativeFieldInfoPtr_RespawnPoint;

		// Token: 0x04007A61 RID: 31329
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
