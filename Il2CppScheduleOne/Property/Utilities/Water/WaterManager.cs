using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities.Water
{
	// Token: 0x02000516 RID: 1302
	public class WaterManager : Singleton<WaterManager>
	{
		// Token: 0x060073EE RID: 29678 RVA: 0x001F9DA4 File Offset: 0x001F7FA4
		// Note: this type is marked as 'beforefieldinit'.
		static WaterManager()
		{
			Il2CppClassPointerStore<WaterManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities.Water", "WaterManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterManager>.NativeClassPtr);
			WaterManager.NativeFieldInfoPtr_waterPipePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, "waterPipePrefab");
			WaterManager.NativeFieldInfoPtr_pricePerL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, "pricePerL");
			WaterManager.NativeFieldInfoPtr_usageAtTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, "usageAtTime");
			WaterManager.NativeFieldInfoPtr_usageThisMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, "usageThisMinute");
			WaterManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, 100677879);
			WaterManager.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, 100677880);
			WaterManager.NativeMethodInfoPtr_DayPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, 100677881);
			WaterManager.NativeMethodInfoPtr_GetTotalUsage_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, 100677882);
			WaterManager.NativeMethodInfoPtr_ConsumeWater_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, 100677883);
			WaterManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterManager>.NativeClassPtr, 100677884);
		}

		// Token: 0x060073EF RID: 29679 RVA: 0x001F9E9C File Offset: 0x001F809C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226637, XrefRangeEnd = 226675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073F0 RID: 29680 RVA: 0x001F9ED8 File Offset: 0x001F80D8
		[CallerCount(0)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterManager.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073F1 RID: 29681 RVA: 0x001F9F0C File Offset: 0x001F810C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226675, XrefRangeEnd = 226679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterManager.NativeMethodInfoPtr_DayPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073F2 RID: 29682 RVA: 0x001F9F40 File Offset: 0x001F8140
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226699, RefRangeEnd = 226701, XrefRangeStart = 226679, XrefRangeEnd = 226699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalUsage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterManager.NativeMethodInfoPtr_GetTotalUsage_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060073F3 RID: 29683 RVA: 0x001F9F7C File Offset: 0x001F817C
		[CallerCount(0)]
		public unsafe void ConsumeWater(float litres)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref litres;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterManager.NativeMethodInfoPtr_ConsumeWater_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073F4 RID: 29684 RVA: 0x001F9FBC File Offset: 0x001F81BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226701, XrefRangeEnd = 226711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073F5 RID: 29685 RVA: 0x0003712E File Offset: 0x0003532E
		public WaterManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002325 RID: 8997
		// (get) Token: 0x060073F6 RID: 29686 RVA: 0x001F9FF8 File Offset: 0x001F81F8
		// (set) Token: 0x060073F7 RID: 29687 RVA: 0x00037137 File Offset: 0x00035337
		public unsafe GameObject waterPipePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterManager.NativeFieldInfoPtr_waterPipePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterManager.NativeFieldInfoPtr_waterPipePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002326 RID: 8998
		// (get) Token: 0x060073F8 RID: 29688 RVA: 0x001FA028 File Offset: 0x001F8228
		// (set) Token: 0x060073F9 RID: 29689 RVA: 0x00037156 File Offset: 0x00035356
		public unsafe static float pricePerL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WaterManager.NativeFieldInfoPtr_pricePerL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaterManager.NativeFieldInfoPtr_pricePerL, (void*)(&value));
			}
		}

		// Token: 0x17002327 RID: 8999
		// (get) Token: 0x060073FA RID: 29690 RVA: 0x001FA044 File Offset: 0x001F8244
		// (set) Token: 0x060073FB RID: 29691 RVA: 0x00037164 File Offset: 0x00035364
		public unsafe Dictionary<int, float> usageAtTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterManager.NativeFieldInfoPtr_usageAtTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterManager.NativeFieldInfoPtr_usageAtTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002328 RID: 9000
		// (get) Token: 0x060073FC RID: 29692 RVA: 0x001FA074 File Offset: 0x001F8274
		// (set) Token: 0x060073FD RID: 29693 RVA: 0x00037183 File Offset: 0x00035383
		public unsafe float usageThisMinute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterManager.NativeFieldInfoPtr_usageThisMinute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterManager.NativeFieldInfoPtr_usageThisMinute)) = value;
			}
		}

		// Token: 0x04004F2C RID: 20268
		private static readonly IntPtr NativeFieldInfoPtr_waterPipePrefab;

		// Token: 0x04004F2D RID: 20269
		private static readonly IntPtr NativeFieldInfoPtr_pricePerL;

		// Token: 0x04004F2E RID: 20270
		private static readonly IntPtr NativeFieldInfoPtr_usageAtTime;

		// Token: 0x04004F2F RID: 20271
		private static readonly IntPtr NativeFieldInfoPtr_usageThisMinute;

		// Token: 0x04004F30 RID: 20272
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004F31 RID: 20273
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04004F32 RID: 20274
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Private_Void_0;

		// Token: 0x04004F33 RID: 20275
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalUsage_Public_Single_0;

		// Token: 0x04004F34 RID: 20276
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeWater_Public_Void_Single_0;

		// Token: 0x04004F35 RID: 20277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
