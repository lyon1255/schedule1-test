using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities.Power
{
	// Token: 0x02000518 RID: 1304
	public class PowerManager : Singleton<PowerManager>
	{
		// Token: 0x0600742A RID: 29738 RVA: 0x001FA9E8 File Offset: 0x001F8BE8
		// Note: this type is marked as 'beforefieldinit'.
		static PowerManager()
		{
			Il2CppClassPointerStore<PowerManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities.Power", "PowerManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerManager>.NativeClassPtr);
			PowerManager.NativeFieldInfoPtr_powerLineSegmentPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, "powerLineSegmentPrefab");
			PowerManager.NativeFieldInfoPtr_pricePerkWh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, "pricePerkWh");
			PowerManager.NativeFieldInfoPtr_usageAtTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, "usageAtTime");
			PowerManager.NativeFieldInfoPtr_usageThisMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, "usageThisMinute");
			PowerManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100677905);
			PowerManager.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100677906);
			PowerManager.NativeMethodInfoPtr_DayPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100677907);
			PowerManager.NativeMethodInfoPtr_GetTotalUsage_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100677908);
			PowerManager.NativeMethodInfoPtr_ConsumePower_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100677909);
			PowerManager.NativeMethodInfoPtr_CreatePowerLine_Public_PowerLine_PowerNode_PowerNode_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100677910);
			PowerManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerManager>.NativeClassPtr, 100677911);
		}

		// Token: 0x0600742B RID: 29739 RVA: 0x001FAAF4 File Offset: 0x001F8CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227111, XrefRangeEnd = 227149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600742C RID: 29740 RVA: 0x001FAB30 File Offset: 0x001F8D30
		[CallerCount(0)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerManager.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600742D RID: 29741 RVA: 0x001FAB64 File Offset: 0x001F8D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227149, XrefRangeEnd = 227153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerManager.NativeMethodInfoPtr_DayPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600742E RID: 29742 RVA: 0x001FAB98 File Offset: 0x001F8D98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227173, RefRangeEnd = 227175, XrefRangeStart = 227153, XrefRangeEnd = 227173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalUsage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerManager.NativeMethodInfoPtr_GetTotalUsage_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600742F RID: 29743 RVA: 0x001FABD4 File Offset: 0x001F8DD4
		[CallerCount(0)]
		public unsafe void ConsumePower(float kwh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref kwh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerManager.NativeMethodInfoPtr_ConsumePower_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007430 RID: 29744 RVA: 0x001FAC14 File Offset: 0x001F8E14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227195, RefRangeEnd = 227198, XrefRangeStart = 227175, XrefRangeEnd = 227195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerLine CreatePowerLine(PowerNode nodeA, PowerNode nodeB, Property p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodeA);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nodeB);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerManager.NativeMethodInfoPtr_CreatePowerLine_Public_PowerLine_PowerNode_PowerNode_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PowerLine>(intPtr3) : null;
		}

		// Token: 0x06007431 RID: 29745 RVA: 0x001FAC88 File Offset: 0x001F8E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227198, XrefRangeEnd = 227208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007432 RID: 29746 RVA: 0x000372C3 File Offset: 0x000354C3
		public PowerManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002335 RID: 9013
		// (get) Token: 0x06007433 RID: 29747 RVA: 0x001FACC4 File Offset: 0x001F8EC4
		// (set) Token: 0x06007434 RID: 29748 RVA: 0x000372CC File Offset: 0x000354CC
		public unsafe GameObject powerLineSegmentPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerManager.NativeFieldInfoPtr_powerLineSegmentPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerManager.NativeFieldInfoPtr_powerLineSegmentPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002336 RID: 9014
		// (get) Token: 0x06007435 RID: 29749 RVA: 0x001FACF4 File Offset: 0x001F8EF4
		// (set) Token: 0x06007436 RID: 29750 RVA: 0x000372EB File Offset: 0x000354EB
		public unsafe static float pricePerkWh
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PowerManager.NativeFieldInfoPtr_pricePerkWh, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerManager.NativeFieldInfoPtr_pricePerkWh, (void*)(&value));
			}
		}

		// Token: 0x17002337 RID: 9015
		// (get) Token: 0x06007437 RID: 29751 RVA: 0x001FAD10 File Offset: 0x001F8F10
		// (set) Token: 0x06007438 RID: 29752 RVA: 0x000372F9 File Offset: 0x000354F9
		public unsafe Dictionary<int, float> usageAtTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerManager.NativeFieldInfoPtr_usageAtTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerManager.NativeFieldInfoPtr_usageAtTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002338 RID: 9016
		// (get) Token: 0x06007439 RID: 29753 RVA: 0x001FAD40 File Offset: 0x001F8F40
		// (set) Token: 0x0600743A RID: 29754 RVA: 0x00037318 File Offset: 0x00035518
		public unsafe float usageThisMinute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerManager.NativeFieldInfoPtr_usageThisMinute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerManager.NativeFieldInfoPtr_usageThisMinute)) = value;
			}
		}

		// Token: 0x04004F54 RID: 20308
		private static readonly IntPtr NativeFieldInfoPtr_powerLineSegmentPrefab;

		// Token: 0x04004F55 RID: 20309
		private static readonly IntPtr NativeFieldInfoPtr_pricePerkWh;

		// Token: 0x04004F56 RID: 20310
		private static readonly IntPtr NativeFieldInfoPtr_usageAtTime;

		// Token: 0x04004F57 RID: 20311
		private static readonly IntPtr NativeFieldInfoPtr_usageThisMinute;

		// Token: 0x04004F58 RID: 20312
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004F59 RID: 20313
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04004F5A RID: 20314
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Private_Void_0;

		// Token: 0x04004F5B RID: 20315
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalUsage_Public_Single_0;

		// Token: 0x04004F5C RID: 20316
		private static readonly IntPtr NativeMethodInfoPtr_ConsumePower_Public_Void_Single_0;

		// Token: 0x04004F5D RID: 20317
		private static readonly IntPtr NativeMethodInfoPtr_CreatePowerLine_Public_PowerLine_PowerNode_PowerNode_Property_0;

		// Token: 0x04004F5E RID: 20318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
