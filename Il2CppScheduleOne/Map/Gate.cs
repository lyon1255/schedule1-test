using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000779 RID: 1913
	public class Gate : MonoBehaviour
	{
		// Token: 0x0600B53E RID: 46398 RVA: 0x002D1340 File Offset: 0x002CF540
		// Note: this type is marked as 'beforefieldinit'.
		static Gate()
		{
			Il2CppClassPointerStore<Gate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "Gate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gate>.NativeClassPtr);
			Gate.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "<IsOpen>k__BackingField");
			Gate.NativeFieldInfoPtr_Gate1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate1");
			Gate.NativeFieldInfoPtr_Gate1Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate1Open");
			Gate.NativeFieldInfoPtr_Gate1Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate1Closed");
			Gate.NativeFieldInfoPtr_Gate2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate2");
			Gate.NativeFieldInfoPtr_Gate2Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate2Open");
			Gate.NativeFieldInfoPtr_Gate2Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Gate2Closed");
			Gate.NativeFieldInfoPtr_OpenSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "OpenSpeed");
			Gate.NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Acceleration");
			Gate.NativeFieldInfoPtr_StartSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "StartSounds");
			Gate.NativeFieldInfoPtr_LoopSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "LoopSounds");
			Gate.NativeFieldInfoPtr_StopSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "StopSounds");
			Gate.NativeFieldInfoPtr_Momentum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "Momentum");
			Gate.NativeFieldInfoPtr_openDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gate>.NativeClassPtr, "openDelta");
			Gate.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100685586);
			Gate.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100685587);
			Gate.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100685588);
			Gate.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100685589);
			Gate.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100685590);
			Gate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gate>.NativeClassPtr, 100685591);
		}

		// Token: 0x1700383C RID: 14396
		// (get) Token: 0x0600B53F RID: 46399 RVA: 0x002D1500 File Offset: 0x002CF700
		// (set) Token: 0x0600B540 RID: 46400 RVA: 0x002D153C File Offset: 0x002CF73C
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B541 RID: 46401 RVA: 0x002D157C File Offset: 0x002CF77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309902, XrefRangeEnd = 309921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B542 RID: 46402 RVA: 0x002D15B0 File Offset: 0x002CF7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309921, XrefRangeEnd = 309922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B543 RID: 46403 RVA: 0x002D15E4 File Offset: 0x002CF7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309922, XrefRangeEnd = 309923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B544 RID: 46404 RVA: 0x002D1618 File Offset: 0x002CF818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309923, XrefRangeEnd = 309924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Gate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Gate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B545 RID: 46405 RVA: 0x00058ECB File Offset: 0x000570CB
		public Gate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700382E RID: 14382
		// (get) Token: 0x0600B546 RID: 46406 RVA: 0x002D1654 File Offset: 0x002CF854
		// (set) Token: 0x0600B547 RID: 46407 RVA: 0x00058ED4 File Offset: 0x000570D4
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700382F RID: 14383
		// (get) Token: 0x0600B548 RID: 46408 RVA: 0x002D167C File Offset: 0x002CF87C
		// (set) Token: 0x0600B549 RID: 46409 RVA: 0x00058EEF File Offset: 0x000570EF
		public unsafe Transform Gate1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003830 RID: 14384
		// (get) Token: 0x0600B54A RID: 46410 RVA: 0x002D16AC File Offset: 0x002CF8AC
		// (set) Token: 0x0600B54B RID: 46411 RVA: 0x00058F0E File Offset: 0x0005710E
		public unsafe Vector3 Gate1Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1Open)) = value;
			}
		}

		// Token: 0x17003831 RID: 14385
		// (get) Token: 0x0600B54C RID: 46412 RVA: 0x002D16D4 File Offset: 0x002CF8D4
		// (set) Token: 0x0600B54D RID: 46413 RVA: 0x00058F29 File Offset: 0x00057129
		public unsafe Vector3 Gate1Closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1Closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate1Closed)) = value;
			}
		}

		// Token: 0x17003832 RID: 14386
		// (get) Token: 0x0600B54E RID: 46414 RVA: 0x002D16FC File Offset: 0x002CF8FC
		// (set) Token: 0x0600B54F RID: 46415 RVA: 0x00058F44 File Offset: 0x00057144
		public unsafe Transform Gate2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003833 RID: 14387
		// (get) Token: 0x0600B550 RID: 46416 RVA: 0x002D172C File Offset: 0x002CF92C
		// (set) Token: 0x0600B551 RID: 46417 RVA: 0x00058F63 File Offset: 0x00057163
		public unsafe Vector3 Gate2Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2Open)) = value;
			}
		}

		// Token: 0x17003834 RID: 14388
		// (get) Token: 0x0600B552 RID: 46418 RVA: 0x002D1754 File Offset: 0x002CF954
		// (set) Token: 0x0600B553 RID: 46419 RVA: 0x00058F7E File Offset: 0x0005717E
		public unsafe Vector3 Gate2Closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2Closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Gate2Closed)) = value;
			}
		}

		// Token: 0x17003835 RID: 14389
		// (get) Token: 0x0600B554 RID: 46420 RVA: 0x002D177C File Offset: 0x002CF97C
		// (set) Token: 0x0600B555 RID: 46421 RVA: 0x00058F99 File Offset: 0x00057199
		public unsafe float OpenSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_OpenSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_OpenSpeed)) = value;
			}
		}

		// Token: 0x17003836 RID: 14390
		// (get) Token: 0x0600B556 RID: 46422 RVA: 0x002D17A4 File Offset: 0x002CF9A4
		// (set) Token: 0x0600B557 RID: 46423 RVA: 0x00058FB4 File Offset: 0x000571B4
		public unsafe float Acceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Acceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Acceleration)) = value;
			}
		}

		// Token: 0x17003837 RID: 14391
		// (get) Token: 0x0600B558 RID: 46424 RVA: 0x002D17CC File Offset: 0x002CF9CC
		// (set) Token: 0x0600B559 RID: 46425 RVA: 0x00058FCF File Offset: 0x000571CF
		public unsafe Il2CppReferenceArray<AudioSourceController> StartSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_StartSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_StartSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003838 RID: 14392
		// (get) Token: 0x0600B55A RID: 46426 RVA: 0x002D17FC File Offset: 0x002CF9FC
		// (set) Token: 0x0600B55B RID: 46427 RVA: 0x00058FEE File Offset: 0x000571EE
		public unsafe Il2CppReferenceArray<AudioSourceController> LoopSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_LoopSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_LoopSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003839 RID: 14393
		// (get) Token: 0x0600B55C RID: 46428 RVA: 0x002D182C File Offset: 0x002CFA2C
		// (set) Token: 0x0600B55D RID: 46429 RVA: 0x0005900D File Offset: 0x0005720D
		public unsafe Il2CppReferenceArray<AudioSourceController> StopSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_StopSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_StopSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700383A RID: 14394
		// (get) Token: 0x0600B55E RID: 46430 RVA: 0x002D185C File Offset: 0x002CFA5C
		// (set) Token: 0x0600B55F RID: 46431 RVA: 0x0005902C File Offset: 0x0005722C
		public unsafe float Momentum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Momentum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_Momentum)) = value;
			}
		}

		// Token: 0x1700383B RID: 14395
		// (get) Token: 0x0600B560 RID: 46432 RVA: 0x002D1884 File Offset: 0x002CFA84
		// (set) Token: 0x0600B561 RID: 46433 RVA: 0x00059047 File Offset: 0x00057247
		public unsafe float openDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_openDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gate.NativeFieldInfoPtr_openDelta)) = value;
			}
		}

		// Token: 0x04007A28 RID: 31272
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04007A29 RID: 31273
		private static readonly IntPtr NativeFieldInfoPtr_Gate1;

		// Token: 0x04007A2A RID: 31274
		private static readonly IntPtr NativeFieldInfoPtr_Gate1Open;

		// Token: 0x04007A2B RID: 31275
		private static readonly IntPtr NativeFieldInfoPtr_Gate1Closed;

		// Token: 0x04007A2C RID: 31276
		private static readonly IntPtr NativeFieldInfoPtr_Gate2;

		// Token: 0x04007A2D RID: 31277
		private static readonly IntPtr NativeFieldInfoPtr_Gate2Open;

		// Token: 0x04007A2E RID: 31278
		private static readonly IntPtr NativeFieldInfoPtr_Gate2Closed;

		// Token: 0x04007A2F RID: 31279
		private static readonly IntPtr NativeFieldInfoPtr_OpenSpeed;

		// Token: 0x04007A30 RID: 31280
		private static readonly IntPtr NativeFieldInfoPtr_Acceleration;

		// Token: 0x04007A31 RID: 31281
		private static readonly IntPtr NativeFieldInfoPtr_StartSounds;

		// Token: 0x04007A32 RID: 31282
		private static readonly IntPtr NativeFieldInfoPtr_LoopSounds;

		// Token: 0x04007A33 RID: 31283
		private static readonly IntPtr NativeFieldInfoPtr_StopSounds;

		// Token: 0x04007A34 RID: 31284
		private static readonly IntPtr NativeFieldInfoPtr_Momentum;

		// Token: 0x04007A35 RID: 31285
		private static readonly IntPtr NativeFieldInfoPtr_openDelta;

		// Token: 0x04007A36 RID: 31286
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007A37 RID: 31287
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04007A38 RID: 31288
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007A39 RID: 31289
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04007A3A RID: 31290
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007A3B RID: 31291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
