using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x0200075D RID: 1885
	public class WateringCanVisuals : MonoBehaviour
	{
		// Token: 0x0600B344 RID: 45892 RVA: 0x002CB754 File Offset: 0x002C9954
		// Note: this type is marked as 'beforefieldinit'.
		static WateringCanVisuals()
		{
			Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.WateringCan", "WateringCanVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr);
			WateringCanVisuals.NativeFieldInfoPtr_OverflowParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "OverflowParticles");
			WateringCanVisuals.NativeFieldInfoPtr_WaterTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "WaterTransform");
			WateringCanVisuals.NativeFieldInfoPtr_WaterMaxY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "WaterMaxY");
			WateringCanVisuals.NativeFieldInfoPtr_WaterMinY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "WaterMinY");
			WateringCanVisuals.NativeFieldInfoPtr_SideWaterTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "SideWaterTransform");
			WateringCanVisuals.NativeFieldInfoPtr_SideWaterMinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "SideWaterMinScale");
			WateringCanVisuals.NativeFieldInfoPtr_SideWaterMaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "SideWaterMaxScale");
			WateringCanVisuals.NativeFieldInfoPtr_FillSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, "FillSound");
			WateringCanVisuals.NativeMethodInfoPtr_SetFillLevel_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, 100685409);
			WateringCanVisuals.NativeMethodInfoPtr_SetOverflowParticles_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, 100685410);
			WateringCanVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr, 100685411);
		}

		// Token: 0x0600B345 RID: 45893 RVA: 0x002CB860 File Offset: 0x002C9A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308383, XrefRangeEnd = 308396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetFillLevel(float normalizedFillLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedFillLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WateringCanVisuals.NativeMethodInfoPtr_SetFillLevel_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B346 RID: 45894 RVA: 0x002CB8AC File Offset: 0x002C9AAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308398, RefRangeEnd = 308399, XrefRangeStart = 308396, XrefRangeEnd = 308398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOverflowParticles(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanVisuals.NativeMethodInfoPtr_SetOverflowParticles_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B347 RID: 45895 RVA: 0x002CB8EC File Offset: 0x002C9AEC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WateringCanVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WateringCanVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B348 RID: 45896 RVA: 0x00057D37 File Offset: 0x00055F37
		public WateringCanVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003791 RID: 14225
		// (get) Token: 0x0600B349 RID: 45897 RVA: 0x002CB928 File Offset: 0x002C9B28
		// (set) Token: 0x0600B34A RID: 45898 RVA: 0x00057D40 File Offset: 0x00055F40
		public unsafe ParticleSystem OverflowParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_OverflowParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_OverflowParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003792 RID: 14226
		// (get) Token: 0x0600B34B RID: 45899 RVA: 0x002CB958 File Offset: 0x002C9B58
		// (set) Token: 0x0600B34C RID: 45900 RVA: 0x00057D5F File Offset: 0x00055F5F
		public unsafe Transform WaterTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_WaterTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_WaterTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003793 RID: 14227
		// (get) Token: 0x0600B34D RID: 45901 RVA: 0x002CB988 File Offset: 0x002C9B88
		// (set) Token: 0x0600B34E RID: 45902 RVA: 0x00057D7E File Offset: 0x00055F7E
		public unsafe float WaterMaxY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_WaterMaxY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_WaterMaxY)) = value;
			}
		}

		// Token: 0x17003794 RID: 14228
		// (get) Token: 0x0600B34F RID: 45903 RVA: 0x002CB9B0 File Offset: 0x002C9BB0
		// (set) Token: 0x0600B350 RID: 45904 RVA: 0x00057D99 File Offset: 0x00055F99
		public unsafe float WaterMinY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_WaterMinY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_WaterMinY)) = value;
			}
		}

		// Token: 0x17003795 RID: 14229
		// (get) Token: 0x0600B351 RID: 45905 RVA: 0x002CB9D8 File Offset: 0x002C9BD8
		// (set) Token: 0x0600B352 RID: 45906 RVA: 0x00057DB4 File Offset: 0x00055FB4
		public unsafe Transform SideWaterTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_SideWaterTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_SideWaterTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003796 RID: 14230
		// (get) Token: 0x0600B353 RID: 45907 RVA: 0x002CBA08 File Offset: 0x002C9C08
		// (set) Token: 0x0600B354 RID: 45908 RVA: 0x00057DD3 File Offset: 0x00055FD3
		public unsafe float SideWaterMinScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_SideWaterMinScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_SideWaterMinScale)) = value;
			}
		}

		// Token: 0x17003797 RID: 14231
		// (get) Token: 0x0600B355 RID: 45909 RVA: 0x002CBA30 File Offset: 0x002C9C30
		// (set) Token: 0x0600B356 RID: 45910 RVA: 0x00057DEE File Offset: 0x00055FEE
		public unsafe float SideWaterMaxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_SideWaterMaxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_SideWaterMaxScale)) = value;
			}
		}

		// Token: 0x17003798 RID: 14232
		// (get) Token: 0x0600B357 RID: 45911 RVA: 0x002CBA58 File Offset: 0x002C9C58
		// (set) Token: 0x0600B358 RID: 45912 RVA: 0x00057E09 File Offset: 0x00056009
		public unsafe AudioSourceController FillSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_FillSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanVisuals.NativeFieldInfoPtr_FillSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040078F2 RID: 30962
		private static readonly IntPtr NativeFieldInfoPtr_OverflowParticles;

		// Token: 0x040078F3 RID: 30963
		private static readonly IntPtr NativeFieldInfoPtr_WaterTransform;

		// Token: 0x040078F4 RID: 30964
		private static readonly IntPtr NativeFieldInfoPtr_WaterMaxY;

		// Token: 0x040078F5 RID: 30965
		private static readonly IntPtr NativeFieldInfoPtr_WaterMinY;

		// Token: 0x040078F6 RID: 30966
		private static readonly IntPtr NativeFieldInfoPtr_SideWaterTransform;

		// Token: 0x040078F7 RID: 30967
		private static readonly IntPtr NativeFieldInfoPtr_SideWaterMinScale;

		// Token: 0x040078F8 RID: 30968
		private static readonly IntPtr NativeFieldInfoPtr_SideWaterMaxScale;

		// Token: 0x040078F9 RID: 30969
		private static readonly IntPtr NativeFieldInfoPtr_FillSound;

		// Token: 0x040078FA RID: 30970
		private static readonly IntPtr NativeMethodInfoPtr_SetFillLevel_Public_Virtual_New_Void_Single_0;

		// Token: 0x040078FB RID: 30971
		private static readonly IntPtr NativeMethodInfoPtr_SetOverflowParticles_Public_Void_Boolean_0;

		// Token: 0x040078FC RID: 30972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
