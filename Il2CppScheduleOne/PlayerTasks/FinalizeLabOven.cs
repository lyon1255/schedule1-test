using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000207 RID: 519
	public class FinalizeLabOven : Task
	{
		// Token: 0x06002B11 RID: 11025 RVA: 0x000F8D60 File Offset: 0x000F6F60
		// Note: this type is marked as 'beforefieldinit'.
		static FinalizeLabOven()
		{
			Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "FinalizeLabOven");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr);
			FinalizeLabOven.NativeFieldInfoPtr_MAX_DISTANCE_FROM_IMPACT_POINT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "MAX_DISTANCE_FROM_IMPACT_POINT");
			FinalizeLabOven.NativeFieldInfoPtr_SMASH_VELOCITY_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "SMASH_VELOCITY_THRESHOLD");
			FinalizeLabOven.NativeFieldInfoPtr_REQUIRED_IMPACTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "REQUIRED_IMPACTS");
			FinalizeLabOven.NativeFieldInfoPtr__Oven_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "<Oven>k__BackingField");
			FinalizeLabOven.NativeFieldInfoPtr_startSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "startSequence");
			FinalizeLabOven.NativeFieldInfoPtr_hammer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "hammer");
			FinalizeLabOven.NativeFieldInfoPtr_impactCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "impactCount");
			FinalizeLabOven.NativeFieldInfoPtr_timeSinceLastImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "timeSinceLastImpact");
			FinalizeLabOven.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668123);
			FinalizeLabOven.NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668124);
			FinalizeLabOven.NativeMethodInfoPtr__ctor_Public_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668125);
			FinalizeLabOven.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668126);
			FinalizeLabOven.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668127);
			FinalizeLabOven.NativeMethodInfoPtr_StartSequence_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668128);
			FinalizeLabOven.NativeMethodInfoPtr_Collision_Public_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668129);
			FinalizeLabOven.NativeMethodInfoPtr_Shatter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668130);
			FinalizeLabOven.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668131);
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06002B12 RID: 11026 RVA: 0x000F8EE4 File Offset: 0x000F70E4
		// (set) Token: 0x06002B13 RID: 11027 RVA: 0x000F8F24 File Offset: 0x000F7124
		public unsafe LabOven Oven
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 43167, RefRangeEnd = 43168, XrefRangeStart = 43167, XrefRangeEnd = 43168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x000F8F68 File Offset: 0x000F7168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121445, RefRangeEnd = 121446, XrefRangeStart = 121424, XrefRangeEnd = 121445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FinalizeLabOven(LabOven oven) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr__ctor_Public_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x000F8FB4 File Offset: 0x000F71B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121446, XrefRangeEnd = 121448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FinalizeLabOven.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x000F8FF0 File Offset: 0x000F71F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121448, XrefRangeEnd = 121480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FinalizeLabOven.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x000F902C File Offset: 0x000F722C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121480, XrefRangeEnd = 121485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StartSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr_StartSequence_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x000F906C File Offset: 0x000F726C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121485, XrefRangeEnd = 121511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Collision(Collision col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr_Collision_Public_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x000F90B0 File Offset: 0x000F72B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121538, RefRangeEnd = 121539, XrefRangeStart = 121511, XrefRangeEnd = 121538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Shatter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr_Shatter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x000F90E4 File Offset: 0x000F72E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121539, XrefRangeEnd = 121544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x00017540 File Offset: 0x00015740
		public FinalizeLabOven(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06002B1C RID: 11036 RVA: 0x000F9124 File Offset: 0x000F7324
		// (set) Token: 0x06002B1D RID: 11037 RVA: 0x00017549 File Offset: 0x00015749
		public unsafe static float MAX_DISTANCE_FROM_IMPACT_POINT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FinalizeLabOven.NativeFieldInfoPtr_MAX_DISTANCE_FROM_IMPACT_POINT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FinalizeLabOven.NativeFieldInfoPtr_MAX_DISTANCE_FROM_IMPACT_POINT, (void*)(&value));
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06002B1E RID: 11038 RVA: 0x000F9140 File Offset: 0x000F7340
		// (set) Token: 0x06002B1F RID: 11039 RVA: 0x00017557 File Offset: 0x00015757
		public unsafe float SMASH_VELOCITY_THRESHOLD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_SMASH_VELOCITY_THRESHOLD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_SMASH_VELOCITY_THRESHOLD)) = value;
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06002B20 RID: 11040 RVA: 0x000F9168 File Offset: 0x000F7368
		// (set) Token: 0x06002B21 RID: 11041 RVA: 0x00017572 File Offset: 0x00015772
		public unsafe static int REQUIRED_IMPACTS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FinalizeLabOven.NativeFieldInfoPtr_REQUIRED_IMPACTS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FinalizeLabOven.NativeFieldInfoPtr_REQUIRED_IMPACTS, (void*)(&value));
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06002B22 RID: 11042 RVA: 0x000F9184 File Offset: 0x000F7384
		// (set) Token: 0x06002B23 RID: 11043 RVA: 0x00017580 File Offset: 0x00015780
		public unsafe LabOven _Oven_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr__Oven_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr__Oven_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06002B24 RID: 11044 RVA: 0x000F91B4 File Offset: 0x000F73B4
		// (set) Token: 0x06002B25 RID: 11045 RVA: 0x0001759F File Offset: 0x0001579F
		public unsafe Coroutine startSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_startSequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_startSequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06002B26 RID: 11046 RVA: 0x000F91E4 File Offset: 0x000F73E4
		// (set) Token: 0x06002B27 RID: 11047 RVA: 0x000175BE File Offset: 0x000157BE
		public unsafe LabOvenHammer hammer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_hammer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOvenHammer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_hammer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06002B28 RID: 11048 RVA: 0x000F9214 File Offset: 0x000F7414
		// (set) Token: 0x06002B29 RID: 11049 RVA: 0x000175DD File Offset: 0x000157DD
		public unsafe int impactCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_impactCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_impactCount)) = value;
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06002B2A RID: 11050 RVA: 0x000F923C File Offset: 0x000F743C
		// (set) Token: 0x06002B2B RID: 11051 RVA: 0x000175F8 File Offset: 0x000157F8
		public unsafe float timeSinceLastImpact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_timeSinceLastImpact);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_timeSinceLastImpact)) = value;
			}
		}

		// Token: 0x04001C92 RID: 7314
		private static readonly IntPtr NativeFieldInfoPtr_MAX_DISTANCE_FROM_IMPACT_POINT;

		// Token: 0x04001C93 RID: 7315
		private static readonly IntPtr NativeFieldInfoPtr_SMASH_VELOCITY_THRESHOLD;

		// Token: 0x04001C94 RID: 7316
		private static readonly IntPtr NativeFieldInfoPtr_REQUIRED_IMPACTS;

		// Token: 0x04001C95 RID: 7317
		private static readonly IntPtr NativeFieldInfoPtr__Oven_k__BackingField;

		// Token: 0x04001C96 RID: 7318
		private static readonly IntPtr NativeFieldInfoPtr_startSequence;

		// Token: 0x04001C97 RID: 7319
		private static readonly IntPtr NativeFieldInfoPtr_hammer;

		// Token: 0x04001C98 RID: 7320
		private static readonly IntPtr NativeFieldInfoPtr_impactCount;

		// Token: 0x04001C99 RID: 7321
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastImpact;

		// Token: 0x04001C9A RID: 7322
		private static readonly IntPtr NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0;

		// Token: 0x04001C9B RID: 7323
		private static readonly IntPtr NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0;

		// Token: 0x04001C9C RID: 7324
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LabOven_0;

		// Token: 0x04001C9D RID: 7325
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001C9E RID: 7326
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001C9F RID: 7327
		private static readonly IntPtr NativeMethodInfoPtr_StartSequence_Private_IEnumerator_0;

		// Token: 0x04001CA0 RID: 7328
		private static readonly IntPtr NativeMethodInfoPtr_Collision_Public_Void_Collision_0;

		// Token: 0x04001CA1 RID: 7329
		private static readonly IntPtr NativeMethodInfoPtr_Shatter_Private_Void_0;

		// Token: 0x04001CA2 RID: 7330
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x020008E0 RID: 2272
		[ObfuscatedName("ScheduleOne.PlayerTasks.FinalizeLabOven+<<Shatter>g__Routine|16_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C466 RID: 50278 RVA: 0x002FD6B4 File Offset: 0x002FB8B4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique()
			{
				Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "<<Shatter>g__Routine|16_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr);
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, "<>1__state");
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, "<>2__current");
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, "<>4__this");
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100668132);
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100668133);
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100668134);
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100668135);
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100668136);
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100668137);
			}

			// Token: 0x0600C467 RID: 50279 RVA: 0x002FD794 File Offset: 0x002FB994
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C468 RID: 50280 RVA: 0x002FD7DC File Offset: 0x002FB9DC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C469 RID: 50281 RVA: 0x002FD810 File Offset: 0x002FBA10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121393, XrefRangeEnd = 121398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D4E RID: 15694
			// (get) Token: 0x0600C46A RID: 50282 RVA: 0x002FD84C File Offset: 0x002FBA4C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C46B RID: 50283 RVA: 0x002FD88C File Offset: 0x002FBA8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121398, XrefRangeEnd = 121403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D4F RID: 15695
			// (get) Token: 0x0600C46C RID: 50284 RVA: 0x002FD8C0 File Offset: 0x002FBAC0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C46D RID: 50285 RVA: 0x0005F948 File Offset: 0x0005DB48
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D4B RID: 15691
			// (get) Token: 0x0600C46E RID: 50286 RVA: 0x002FD900 File Offset: 0x002FBB00
			// (set) Token: 0x0600C46F RID: 50287 RVA: 0x0005F951 File Offset: 0x0005DB51
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D4C RID: 15692
			// (get) Token: 0x0600C470 RID: 50288 RVA: 0x002FD928 File Offset: 0x002FBB28
			// (set) Token: 0x0600C471 RID: 50289 RVA: 0x0005F96C File Offset: 0x0005DB6C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D4D RID: 15693
			// (get) Token: 0x0600C472 RID: 50290 RVA: 0x002FD958 File Offset: 0x002FBB58
			// (set) Token: 0x0600C473 RID: 50291 RVA: 0x0005F98B File Offset: 0x0005DB8B
			public unsafe FinalizeLabOven __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FinalizeLabOven>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008520 RID: 34080
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008521 RID: 34081
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008522 RID: 34082
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008523 RID: 34083
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008524 RID: 34084
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008525 RID: 34085
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008526 RID: 34086
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008527 RID: 34087
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008528 RID: 34088
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020008E1 RID: 2273
		[ObfuscatedName("ScheduleOne.PlayerTasks.FinalizeLabOven+<StartSequence>d__14")]
		public sealed class _StartSequence_d__14 : Il2CppSystem.Object
		{
			// Token: 0x0600C474 RID: 50292 RVA: 0x002FD988 File Offset: 0x002FBB88
			// Note: this type is marked as 'beforefieldinit'.
			static _StartSequence_d__14()
			{
				Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "<StartSequence>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr);
				FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, "<>1__state");
				FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, "<>2__current");
				FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, "<>4__this");
				FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, 100668138);
				FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, 100668139);
				FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, 100668140);
				FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, 100668141);
				FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, 100668142);
				FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, 100668143);
			}

			// Token: 0x0600C475 RID: 50293 RVA: 0x002FDA68 File Offset: 0x002FBC68
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StartSequence_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C476 RID: 50294 RVA: 0x002FDAB0 File Offset: 0x002FBCB0
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C477 RID: 50295 RVA: 0x002FDAE4 File Offset: 0x002FBCE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121403, XrefRangeEnd = 121419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D53 RID: 15699
			// (get) Token: 0x0600C478 RID: 50296 RVA: 0x002FDB20 File Offset: 0x002FBD20
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C479 RID: 50297 RVA: 0x002FDB60 File Offset: 0x002FBD60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121419, XrefRangeEnd = 121424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D54 RID: 15700
			// (get) Token: 0x0600C47A RID: 50298 RVA: 0x002FDB94 File Offset: 0x002FBD94
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C47B RID: 50299 RVA: 0x0005F9AA File Offset: 0x0005DBAA
			public _StartSequence_d__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D50 RID: 15696
			// (get) Token: 0x0600C47C RID: 50300 RVA: 0x002FDBD4 File Offset: 0x002FBDD4
			// (set) Token: 0x0600C47D RID: 50301 RVA: 0x0005F9B3 File Offset: 0x0005DBB3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D51 RID: 15697
			// (get) Token: 0x0600C47E RID: 50302 RVA: 0x002FDBFC File Offset: 0x002FBDFC
			// (set) Token: 0x0600C47F RID: 50303 RVA: 0x0005F9CE File Offset: 0x0005DBCE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D52 RID: 15698
			// (get) Token: 0x0600C480 RID: 50304 RVA: 0x002FDC2C File Offset: 0x002FBE2C
			// (set) Token: 0x0600C481 RID: 50305 RVA: 0x0005F9ED File Offset: 0x0005DBED
			public unsafe FinalizeLabOven __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FinalizeLabOven>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008529 RID: 34089
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400852A RID: 34090
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400852B RID: 34091
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400852C RID: 34092
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400852D RID: 34093
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400852E RID: 34094
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400852F RID: 34095
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008530 RID: 34096
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008531 RID: 34097
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
