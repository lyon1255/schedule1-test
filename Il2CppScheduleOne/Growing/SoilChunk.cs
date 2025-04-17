using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200055E RID: 1374
	public class SoilChunk : Clickable
	{
		// Token: 0x060078B7 RID: 30903 RVA: 0x002099A8 File Offset: 0x00207BA8
		// Note: this type is marked as 'beforefieldinit'.
		static SoilChunk()
		{
			Il2CppClassPointerStore<SoilChunk>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "SoilChunk");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr);
			SoilChunk.NativeFieldInfoPtr__CurrentLerp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "<CurrentLerp>k__BackingField");
			SoilChunk.NativeFieldInfoPtr_EndTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "EndTransform");
			SoilChunk.NativeFieldInfoPtr_LerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "LerpTime");
			SoilChunk.NativeFieldInfoPtr_localPos_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "localPos_Start");
			SoilChunk.NativeFieldInfoPtr_localEulerAngles_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "localEulerAngles_Start");
			SoilChunk.NativeFieldInfoPtr_localScale_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "localScale_Start");
			SoilChunk.NativeFieldInfoPtr_lerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "lerpRoutine");
			SoilChunk.NativeMethodInfoPtr_get_CurrentLerp_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678433);
			SoilChunk.NativeMethodInfoPtr_set_CurrentLerp_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678434);
			SoilChunk.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678435);
			SoilChunk.NativeMethodInfoPtr_SetLerpedTransform_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678436);
			SoilChunk.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678437);
			SoilChunk.NativeMethodInfoPtr_StopLerp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678438);
			SoilChunk.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678439);
			SoilChunk.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678440);
		}

		// Token: 0x17002488 RID: 9352
		// (get) Token: 0x060078B8 RID: 30904 RVA: 0x00209B04 File Offset: 0x00207D04
		// (set) Token: 0x060078B9 RID: 30905 RVA: 0x00209B40 File Offset: 0x00207D40
		public unsafe float CurrentLerp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_get_CurrentLerp_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_set_CurrentLerp_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060078BA RID: 30906 RVA: 0x00209B80 File Offset: 0x00207D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232532, XrefRangeEnd = 232538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilChunk.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078BB RID: 30907 RVA: 0x00209BBC File Offset: 0x00207DBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 232553, RefRangeEnd = 232555, XrefRangeStart = 232538, XrefRangeEnd = 232553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLerpedTransform(float _lerp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _lerp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_SetLerpedTransform_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078BC RID: 30908 RVA: 0x00209BFC File Offset: 0x00207DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232555, XrefRangeEnd = 232564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilChunk.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078BD RID: 30909 RVA: 0x00209C48 File Offset: 0x00207E48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232565, RefRangeEnd = 232566, XrefRangeStart = 232564, XrefRangeEnd = 232565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopLerp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_StopLerp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078BE RID: 30910 RVA: 0x00209C7C File Offset: 0x00207E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232566, XrefRangeEnd = 232567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoilChunk() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078BF RID: 30911 RVA: 0x00209CB8 File Offset: 0x00207EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232567, XrefRangeEnd = 232572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060078C0 RID: 30912 RVA: 0x000394B0 File Offset: 0x000376B0
		public SoilChunk(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002481 RID: 9345
		// (get) Token: 0x060078C1 RID: 30913 RVA: 0x00209CF8 File Offset: 0x00207EF8
		// (set) Token: 0x060078C2 RID: 30914 RVA: 0x000394B9 File Offset: 0x000376B9
		public unsafe float _CurrentLerp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr__CurrentLerp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr__CurrentLerp_k__BackingField)) = value;
			}
		}

		// Token: 0x17002482 RID: 9346
		// (get) Token: 0x060078C3 RID: 30915 RVA: 0x00209D20 File Offset: 0x00207F20
		// (set) Token: 0x060078C4 RID: 30916 RVA: 0x000394D4 File Offset: 0x000376D4
		public unsafe Transform EndTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_EndTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_EndTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002483 RID: 9347
		// (get) Token: 0x060078C5 RID: 30917 RVA: 0x00209D50 File Offset: 0x00207F50
		// (set) Token: 0x060078C6 RID: 30918 RVA: 0x000394F3 File Offset: 0x000376F3
		public unsafe float LerpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_LerpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_LerpTime)) = value;
			}
		}

		// Token: 0x17002484 RID: 9348
		// (get) Token: 0x060078C7 RID: 30919 RVA: 0x00209D78 File Offset: 0x00207F78
		// (set) Token: 0x060078C8 RID: 30920 RVA: 0x0003950E File Offset: 0x0003770E
		public unsafe Vector3 localPos_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localPos_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localPos_Start)) = value;
			}
		}

		// Token: 0x17002485 RID: 9349
		// (get) Token: 0x060078C9 RID: 30921 RVA: 0x00209DA0 File Offset: 0x00207FA0
		// (set) Token: 0x060078CA RID: 30922 RVA: 0x00039529 File Offset: 0x00037729
		public unsafe Vector3 localEulerAngles_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localEulerAngles_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localEulerAngles_Start)) = value;
			}
		}

		// Token: 0x17002486 RID: 9350
		// (get) Token: 0x060078CB RID: 30923 RVA: 0x00209DC8 File Offset: 0x00207FC8
		// (set) Token: 0x060078CC RID: 30924 RVA: 0x00039544 File Offset: 0x00037744
		public unsafe Vector3 localScale_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localScale_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localScale_Start)) = value;
			}
		}

		// Token: 0x17002487 RID: 9351
		// (get) Token: 0x060078CD RID: 30925 RVA: 0x00209DF0 File Offset: 0x00207FF0
		// (set) Token: 0x060078CE RID: 30926 RVA: 0x0003955F File Offset: 0x0003775F
		public unsafe Coroutine lerpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_lerpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_lerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005238 RID: 21048
		private static readonly IntPtr NativeFieldInfoPtr__CurrentLerp_k__BackingField;

		// Token: 0x04005239 RID: 21049
		private static readonly IntPtr NativeFieldInfoPtr_EndTransform;

		// Token: 0x0400523A RID: 21050
		private static readonly IntPtr NativeFieldInfoPtr_LerpTime;

		// Token: 0x0400523B RID: 21051
		private static readonly IntPtr NativeFieldInfoPtr_localPos_Start;

		// Token: 0x0400523C RID: 21052
		private static readonly IntPtr NativeFieldInfoPtr_localEulerAngles_Start;

		// Token: 0x0400523D RID: 21053
		private static readonly IntPtr NativeFieldInfoPtr_localScale_Start;

		// Token: 0x0400523E RID: 21054
		private static readonly IntPtr NativeFieldInfoPtr_lerpRoutine;

		// Token: 0x0400523F RID: 21055
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLerp_Public_get_Single_0;

		// Token: 0x04005240 RID: 21056
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLerp_Protected_set_Void_Single_0;

		// Token: 0x04005241 RID: 21057
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005242 RID: 21058
		private static readonly IntPtr NativeMethodInfoPtr_SetLerpedTransform_Public_Void_Single_0;

		// Token: 0x04005243 RID: 21059
		private static readonly IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0;

		// Token: 0x04005244 RID: 21060
		private static readonly IntPtr NativeMethodInfoPtr_StopLerp_Public_Void_0;

		// Token: 0x04005245 RID: 21061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005246 RID: 21062
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000AA6 RID: 2726
		[ObfuscatedName("ScheduleOne.Growing.SoilChunk+<<StartClick>g__Lerp|12_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D32B RID: 54059 RVA: 0x0032772C File Offset: 0x0032592C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique()
			{
				Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "<<StartClick>g__Lerp|12_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, "<>1__state");
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, "<>2__current");
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, "<>4__this");
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, "<i>5__2");
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678441);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678442);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678443);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678444);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678445);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678446);
			}

			// Token: 0x0600D32C RID: 54060 RVA: 0x00327820 File Offset: 0x00325A20
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D32D RID: 54061 RVA: 0x00327868 File Offset: 0x00325A68
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D32E RID: 54062 RVA: 0x0032789C File Offset: 0x00325A9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232518, XrefRangeEnd = 232527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004180 RID: 16768
			// (get) Token: 0x0600D32F RID: 54063 RVA: 0x003278D8 File Offset: 0x00325AD8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D330 RID: 54064 RVA: 0x00327918 File Offset: 0x00325B18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232527, XrefRangeEnd = 232532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004181 RID: 16769
			// (get) Token: 0x0600D331 RID: 54065 RVA: 0x0032794C File Offset: 0x00325B4C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D332 RID: 54066 RVA: 0x00066C94 File Offset: 0x00064E94
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700417C RID: 16764
			// (get) Token: 0x0600D333 RID: 54067 RVA: 0x0032798C File Offset: 0x00325B8C
			// (set) Token: 0x0600D334 RID: 54068 RVA: 0x00066C9D File Offset: 0x00064E9D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700417D RID: 16765
			// (get) Token: 0x0600D335 RID: 54069 RVA: 0x003279B4 File Offset: 0x00325BB4
			// (set) Token: 0x0600D336 RID: 54070 RVA: 0x00066CB8 File Offset: 0x00064EB8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700417E RID: 16766
			// (get) Token: 0x0600D337 RID: 54071 RVA: 0x003279E4 File Offset: 0x00325BE4
			// (set) Token: 0x0600D338 RID: 54072 RVA: 0x00066CD7 File Offset: 0x00064ED7
			public unsafe SoilChunk __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SoilChunk>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700417F RID: 16767
			// (get) Token: 0x0600D339 RID: 54073 RVA: 0x00327A14 File Offset: 0x00325C14
			// (set) Token: 0x0600D33A RID: 54074 RVA: 0x00066CF6 File Offset: 0x00064EF6
			public unsafe float _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04008E4A RID: 36426
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008E4B RID: 36427
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008E4C RID: 36428
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E4D RID: 36429
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04008E4E RID: 36430
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008E4F RID: 36431
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E50 RID: 36432
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008E51 RID: 36433
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008E52 RID: 36434
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E53 RID: 36435
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
