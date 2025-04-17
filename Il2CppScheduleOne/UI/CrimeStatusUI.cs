using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000654 RID: 1620
	public class CrimeStatusUI : MonoBehaviour
	{
		// Token: 0x0600908F RID: 37007 RVA: 0x00256AC0 File Offset: 0x00254CC0
		// Note: this type is marked as 'beforefieldinit'.
		static CrimeStatusUI()
		{
			Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CrimeStatusUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr);
			CrimeStatusUI.NativeFieldInfoPtr_SmallTextSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "SmallTextSize");
			CrimeStatusUI.NativeFieldInfoPtr_LargeTextSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "LargeTextSize");
			CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "CrimeStatusContainer");
			CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "CrimeStatusGroup");
			CrimeStatusUI.NativeFieldInfoPtr_BodysearchLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "BodysearchLabel");
			CrimeStatusUI.NativeFieldInfoPtr_InvestigatingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "InvestigatingMask");
			CrimeStatusUI.NativeFieldInfoPtr_UnderArrestMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "UnderArrestMask");
			CrimeStatusUI.NativeFieldInfoPtr_WantedMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "WantedMask");
			CrimeStatusUI.NativeFieldInfoPtr_WantedDeadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "WantedDeadMask");
			CrimeStatusUI.NativeFieldInfoPtr_ArrestProgressContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "ArrestProgressContainer");
			CrimeStatusUI.NativeFieldInfoPtr_animateText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "animateText");
			CrimeStatusUI.NativeFieldInfoPtr_routine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "routine");
			CrimeStatusUI.NativeMethodInfoPtr_UpdateStatus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, 100681206);
			CrimeStatusUI.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, 100681207);
			CrimeStatusUI.NativeMethodInfoPtr_Routine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, 100681208);
			CrimeStatusUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, 100681209);
		}

		// Token: 0x06009090 RID: 37008 RVA: 0x00256C30 File Offset: 0x00254E30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261816, RefRangeEnd = 261818, XrefRangeStart = 261775, XrefRangeEnd = 261816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI.NativeMethodInfoPtr_UpdateStatus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009091 RID: 37009 RVA: 0x00256C64 File Offset: 0x00254E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261818, XrefRangeEnd = 261826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009092 RID: 37010 RVA: 0x00256C98 File Offset: 0x00254E98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261831, RefRangeEnd = 261833, XrefRangeStart = 261826, XrefRangeEnd = 261831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Routine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI.NativeMethodInfoPtr_Routine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009093 RID: 37011 RVA: 0x00256CD8 File Offset: 0x00254ED8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrimeStatusUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009094 RID: 37012 RVA: 0x00045CCD File Offset: 0x00043ECD
		public CrimeStatusUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C44 RID: 11332
		// (get) Token: 0x06009095 RID: 37013 RVA: 0x00256D14 File Offset: 0x00254F14
		// (set) Token: 0x06009096 RID: 37014 RVA: 0x00045CD6 File Offset: 0x00043ED6
		public unsafe static float SmallTextSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CrimeStatusUI.NativeFieldInfoPtr_SmallTextSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CrimeStatusUI.NativeFieldInfoPtr_SmallTextSize, (void*)(&value));
			}
		}

		// Token: 0x17002C45 RID: 11333
		// (get) Token: 0x06009097 RID: 37015 RVA: 0x00256D30 File Offset: 0x00254F30
		// (set) Token: 0x06009098 RID: 37016 RVA: 0x00045CE4 File Offset: 0x00043EE4
		public unsafe static float LargeTextSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CrimeStatusUI.NativeFieldInfoPtr_LargeTextSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CrimeStatusUI.NativeFieldInfoPtr_LargeTextSize, (void*)(&value));
			}
		}

		// Token: 0x17002C46 RID: 11334
		// (get) Token: 0x06009099 RID: 37017 RVA: 0x00256D4C File Offset: 0x00254F4C
		// (set) Token: 0x0600909A RID: 37018 RVA: 0x00045CF2 File Offset: 0x00043EF2
		public unsafe RectTransform CrimeStatusContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C47 RID: 11335
		// (get) Token: 0x0600909B RID: 37019 RVA: 0x00256D7C File Offset: 0x00254F7C
		// (set) Token: 0x0600909C RID: 37020 RVA: 0x00045D11 File Offset: 0x00043F11
		public unsafe CanvasGroup CrimeStatusGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C48 RID: 11336
		// (get) Token: 0x0600909D RID: 37021 RVA: 0x00256DAC File Offset: 0x00254FAC
		// (set) Token: 0x0600909E RID: 37022 RVA: 0x00045D30 File Offset: 0x00043F30
		public unsafe GameObject BodysearchLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_BodysearchLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_BodysearchLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C49 RID: 11337
		// (get) Token: 0x0600909F RID: 37023 RVA: 0x00256DDC File Offset: 0x00254FDC
		// (set) Token: 0x060090A0 RID: 37024 RVA: 0x00045D4F File Offset: 0x00043F4F
		public unsafe Image InvestigatingMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_InvestigatingMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_InvestigatingMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C4A RID: 11338
		// (get) Token: 0x060090A1 RID: 37025 RVA: 0x00256E0C File Offset: 0x0025500C
		// (set) Token: 0x060090A2 RID: 37026 RVA: 0x00045D6E File Offset: 0x00043F6E
		public unsafe Image UnderArrestMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_UnderArrestMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_UnderArrestMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C4B RID: 11339
		// (get) Token: 0x060090A3 RID: 37027 RVA: 0x00256E3C File Offset: 0x0025503C
		// (set) Token: 0x060090A4 RID: 37028 RVA: 0x00045D8D File Offset: 0x00043F8D
		public unsafe Image WantedMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_WantedMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_WantedMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C4C RID: 11340
		// (get) Token: 0x060090A5 RID: 37029 RVA: 0x00256E6C File Offset: 0x0025506C
		// (set) Token: 0x060090A6 RID: 37030 RVA: 0x00045DAC File Offset: 0x00043FAC
		public unsafe Image WantedDeadMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_WantedDeadMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_WantedDeadMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C4D RID: 11341
		// (get) Token: 0x060090A7 RID: 37031 RVA: 0x00256E9C File Offset: 0x0025509C
		// (set) Token: 0x060090A8 RID: 37032 RVA: 0x00045DCB File Offset: 0x00043FCB
		public unsafe GameObject ArrestProgressContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_ArrestProgressContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_ArrestProgressContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C4E RID: 11342
		// (get) Token: 0x060090A9 RID: 37033 RVA: 0x00256ECC File Offset: 0x002550CC
		// (set) Token: 0x060090AA RID: 37034 RVA: 0x00045DEA File Offset: 0x00043FEA
		public unsafe bool animateText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_animateText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_animateText)) = value;
			}
		}

		// Token: 0x17002C4F RID: 11343
		// (get) Token: 0x060090AB RID: 37035 RVA: 0x00256EF4 File Offset: 0x002550F4
		// (set) Token: 0x060090AC RID: 37036 RVA: 0x00045E05 File Offset: 0x00044005
		public unsafe Coroutine routine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_routine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_routine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040061C2 RID: 25026
		private static readonly IntPtr NativeFieldInfoPtr_SmallTextSize;

		// Token: 0x040061C3 RID: 25027
		private static readonly IntPtr NativeFieldInfoPtr_LargeTextSize;

		// Token: 0x040061C4 RID: 25028
		private static readonly IntPtr NativeFieldInfoPtr_CrimeStatusContainer;

		// Token: 0x040061C5 RID: 25029
		private static readonly IntPtr NativeFieldInfoPtr_CrimeStatusGroup;

		// Token: 0x040061C6 RID: 25030
		private static readonly IntPtr NativeFieldInfoPtr_BodysearchLabel;

		// Token: 0x040061C7 RID: 25031
		private static readonly IntPtr NativeFieldInfoPtr_InvestigatingMask;

		// Token: 0x040061C8 RID: 25032
		private static readonly IntPtr NativeFieldInfoPtr_UnderArrestMask;

		// Token: 0x040061C9 RID: 25033
		private static readonly IntPtr NativeFieldInfoPtr_WantedMask;

		// Token: 0x040061CA RID: 25034
		private static readonly IntPtr NativeFieldInfoPtr_WantedDeadMask;

		// Token: 0x040061CB RID: 25035
		private static readonly IntPtr NativeFieldInfoPtr_ArrestProgressContainer;

		// Token: 0x040061CC RID: 25036
		private static readonly IntPtr NativeFieldInfoPtr_animateText;

		// Token: 0x040061CD RID: 25037
		private static readonly IntPtr NativeFieldInfoPtr_routine;

		// Token: 0x040061CE RID: 25038
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStatus_Public_Void_0;

		// Token: 0x040061CF RID: 25039
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040061D0 RID: 25040
		private static readonly IntPtr NativeMethodInfoPtr_Routine_Private_IEnumerator_0;

		// Token: 0x040061D1 RID: 25041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B3C RID: 2876
		[ObfuscatedName("ScheduleOne.UI.CrimeStatusUI+<Routine>d__14")]
		public sealed class _Routine_d__14 : Il2CppSystem.Object
		{
			// Token: 0x0600D87A RID: 55418 RVA: 0x0033680C File Offset: 0x00334A0C
			// Note: this type is marked as 'beforefieldinit'.
			static _Routine_d__14()
			{
				Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "<Routine>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr);
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<>1__state");
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<>2__current");
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<>4__this");
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<lerpTime>5__2");
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__t_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<t>5__3");
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100681210);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100681211);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100681212);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100681213);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100681214);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100681215);
			}

			// Token: 0x0600D87B RID: 55419 RVA: 0x00336914 File Offset: 0x00334B14
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Routine_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D87C RID: 55420 RVA: 0x0033695C File Offset: 0x00334B5C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D87D RID: 55421 RVA: 0x00336990 File Offset: 0x00334B90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261753, XrefRangeEnd = 261770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004325 RID: 17189
			// (get) Token: 0x0600D87E RID: 55422 RVA: 0x003369CC File Offset: 0x00334BCC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D87F RID: 55423 RVA: 0x00336A0C File Offset: 0x00334C0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261770, XrefRangeEnd = 261775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004326 RID: 17190
			// (get) Token: 0x0600D880 RID: 55424 RVA: 0x00336A40 File Offset: 0x00334C40
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D881 RID: 55425 RVA: 0x000696E3 File Offset: 0x000678E3
			public _Routine_d__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004320 RID: 17184
			// (get) Token: 0x0600D882 RID: 55426 RVA: 0x00336A80 File Offset: 0x00334C80
			// (set) Token: 0x0600D883 RID: 55427 RVA: 0x000696EC File Offset: 0x000678EC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004321 RID: 17185
			// (get) Token: 0x0600D884 RID: 55428 RVA: 0x00336AA8 File Offset: 0x00334CA8
			// (set) Token: 0x0600D885 RID: 55429 RVA: 0x00069707 File Offset: 0x00067907
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004322 RID: 17186
			// (get) Token: 0x0600D886 RID: 55430 RVA: 0x00336AD8 File Offset: 0x00334CD8
			// (set) Token: 0x0600D887 RID: 55431 RVA: 0x00069726 File Offset: 0x00067926
			public unsafe CrimeStatusUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CrimeStatusUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004323 RID: 17187
			// (get) Token: 0x0600D888 RID: 55432 RVA: 0x00336B08 File Offset: 0x00334D08
			// (set) Token: 0x0600D889 RID: 55433 RVA: 0x00069745 File Offset: 0x00067945
			public unsafe float _lerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x17004324 RID: 17188
			// (get) Token: 0x0600D88A RID: 55434 RVA: 0x00336B30 File Offset: 0x00334D30
			// (set) Token: 0x0600D88B RID: 55435 RVA: 0x00069760 File Offset: 0x00067960
			public unsafe float _t_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__t_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__t_5__3)) = value;
				}
			}

			// Token: 0x0400917A RID: 37242
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400917B RID: 37243
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400917C RID: 37244
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400917D RID: 37245
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x0400917E RID: 37246
			private static readonly IntPtr NativeFieldInfoPtr__t_5__3;

			// Token: 0x0400917F RID: 37247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009180 RID: 37248
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009181 RID: 37249
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009182 RID: 37250
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009183 RID: 37251
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009184 RID: 37252
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
