using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000539 RID: 1337
	[Serializable]
	public class FloatSmoother : Object
	{
		// Token: 0x060076CA RID: 30410 RVA: 0x002041BC File Offset: 0x002023BC
		// Note: this type is marked as 'beforefieldinit'.
		static FloatSmoother()
		{
			Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "FloatSmoother");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr);
			FloatSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<CurrentValue>k__BackingField");
			FloatSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<Multiplier>k__BackingField");
			FloatSmoother.NativeFieldInfoPtr_DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "DefaultValue");
			FloatSmoother.NativeFieldInfoPtr_SmoothingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "SmoothingSpeed");
			FloatSmoother.NativeFieldInfoPtr_overrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "overrides");
			FloatSmoother.NativeMethodInfoPtr_get_CurrentValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678256);
			FloatSmoother.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678257);
			FloatSmoother.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678258);
			FloatSmoother.NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678259);
			FloatSmoother.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678260);
			FloatSmoother.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678261);
			FloatSmoother.NativeMethodInfoPtr_SetDefault_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678262);
			FloatSmoother.NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678263);
			FloatSmoother.NativeMethodInfoPtr_SetSmoothingSpeed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678264);
			FloatSmoother.NativeMethodInfoPtr_AddOverride_Public_Void_Single_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678265);
			FloatSmoother.NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678266);
			FloatSmoother.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678267);
			FloatSmoother.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100678268);
		}

		// Token: 0x170023F6 RID: 9206
		// (get) Token: 0x060076CB RID: 30411 RVA: 0x00204354 File Offset: 0x00202554
		// (set) Token: 0x060076CC RID: 30412 RVA: 0x00204390 File Offset: 0x00202590
		public unsafe float CurrentValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_get_CurrentValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 29949, RefRangeEnd = 29953, XrefRangeStart = 29949, XrefRangeEnd = 29953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170023F7 RID: 9207
		// (get) Token: 0x060076CD RID: 30413 RVA: 0x002043D0 File Offset: 0x002025D0
		// (set) Token: 0x060076CE RID: 30414 RVA: 0x0020440C File Offset: 0x0020260C
		public unsafe float Multiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27828, RefRangeEnd = 27829, XrefRangeStart = 27828, XrefRangeEnd = 27829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060076CF RID: 30415 RVA: 0x0020444C File Offset: 0x0020264C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 230996, RefRangeEnd = 231009, XrefRangeStart = 230975, XrefRangeEnd = 230996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076D0 RID: 30416 RVA: 0x00204480 File Offset: 0x00202680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231009, XrefRangeEnd = 231027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076D1 RID: 30417 RVA: 0x002044B4 File Offset: 0x002026B4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 231030, RefRangeEnd = 231041, XrefRangeStart = 231027, XrefRangeEnd = 231030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefault(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_SetDefault_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076D2 RID: 30418 RVA: 0x002044F4 File Offset: 0x002026F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 27828, RefRangeEnd = 27829, XrefRangeStart = 27828, XrefRangeEnd = 27829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMultiplier(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076D3 RID: 30419 RVA: 0x00204534 File Offset: 0x00202734
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 29998, RefRangeEnd = 30009, XrefRangeStart = 29998, XrefRangeEnd = 30009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSmoothingSpeed(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_SetSmoothingSpeed_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076D4 RID: 30420 RVA: 0x00204574 File Offset: 0x00202774
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 231085, RefRangeEnd = 231114, XrefRangeStart = 231041, XrefRangeEnd = 231085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOverride(float value, int priority, string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_AddOverride_Public_Void_Single_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076D5 RID: 30421 RVA: 0x002045D4 File Offset: 0x002027D4
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 231150, RefRangeEnd = 231177, XrefRangeStart = 231114, XrefRangeEnd = 231150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOverride(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076D6 RID: 30422 RVA: 0x00204618 File Offset: 0x00202818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231177, XrefRangeEnd = 231183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076D7 RID: 30423 RVA: 0x0020464C File Offset: 0x0020284C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 231191, RefRangeEnd = 231192, XrefRangeStart = 231183, XrefRangeEnd = 231191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloatSmoother() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076D8 RID: 30424 RVA: 0x00038476 File Offset: 0x00036676
		public FloatSmoother(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023F1 RID: 9201
		// (get) Token: 0x060076D9 RID: 30425 RVA: 0x00204688 File Offset: 0x00202888
		// (set) Token: 0x060076DA RID: 30426 RVA: 0x0003847F File Offset: 0x0003667F
		public unsafe float _CurrentValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField)) = value;
			}
		}

		// Token: 0x170023F2 RID: 9202
		// (get) Token: 0x060076DB RID: 30427 RVA: 0x002046B0 File Offset: 0x002028B0
		// (set) Token: 0x060076DC RID: 30428 RVA: 0x0003849A File Offset: 0x0003669A
		public unsafe float _Multiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x170023F3 RID: 9203
		// (get) Token: 0x060076DD RID: 30429 RVA: 0x002046D8 File Offset: 0x002028D8
		// (set) Token: 0x060076DE RID: 30430 RVA: 0x000384B5 File Offset: 0x000366B5
		public unsafe float DefaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_DefaultValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_DefaultValue)) = value;
			}
		}

		// Token: 0x170023F4 RID: 9204
		// (get) Token: 0x060076DF RID: 30431 RVA: 0x00204700 File Offset: 0x00202900
		// (set) Token: 0x060076E0 RID: 30432 RVA: 0x000384D0 File Offset: 0x000366D0
		public unsafe float SmoothingSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_SmoothingSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_SmoothingSpeed)) = value;
			}
		}

		// Token: 0x170023F5 RID: 9205
		// (get) Token: 0x060076E1 RID: 30433 RVA: 0x00204728 File Offset: 0x00202928
		// (set) Token: 0x060076E2 RID: 30434 RVA: 0x000384EB File Offset: 0x000366EB
		public unsafe List<FloatSmoother.Override> overrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_overrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FloatSmoother.Override>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_overrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400511B RID: 20763
		private static readonly IntPtr NativeFieldInfoPtr__CurrentValue_k__BackingField;

		// Token: 0x0400511C RID: 20764
		private static readonly IntPtr NativeFieldInfoPtr__Multiplier_k__BackingField;

		// Token: 0x0400511D RID: 20765
		private static readonly IntPtr NativeFieldInfoPtr_DefaultValue;

		// Token: 0x0400511E RID: 20766
		private static readonly IntPtr NativeFieldInfoPtr_SmoothingSpeed;

		// Token: 0x0400511F RID: 20767
		private static readonly IntPtr NativeFieldInfoPtr_overrides;

		// Token: 0x04005120 RID: 20768
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_get_Single_0;

		// Token: 0x04005121 RID: 20769
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Single_0;

		// Token: 0x04005122 RID: 20770
		private static readonly IntPtr NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0;

		// Token: 0x04005123 RID: 20771
		private static readonly IntPtr NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0;

		// Token: 0x04005124 RID: 20772
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x04005125 RID: 20773
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x04005126 RID: 20774
		private static readonly IntPtr NativeMethodInfoPtr_SetDefault_Public_Void_Single_0;

		// Token: 0x04005127 RID: 20775
		private static readonly IntPtr NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0;

		// Token: 0x04005128 RID: 20776
		private static readonly IntPtr NativeMethodInfoPtr_SetSmoothingSpeed_Public_Void_Single_0;

		// Token: 0x04005129 RID: 20777
		private static readonly IntPtr NativeMethodInfoPtr_AddOverride_Public_Void_Single_Int32_String_0;

		// Token: 0x0400512A RID: 20778
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0;

		// Token: 0x0400512B RID: 20779
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400512C RID: 20780
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A9D RID: 2717
		public class Override : Object
		{
			// Token: 0x0600D2E3 RID: 53987 RVA: 0x00326ADC File Offset: 0x00324CDC
			// Note: this type is marked as 'beforefieldinit'.
			static Override()
			{
				Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "Override");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr);
				FloatSmoother.Override.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr, "Value");
				FloatSmoother.Override.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr, "Priority");
				FloatSmoother.Override.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr, "Label");
				FloatSmoother.Override.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr, 100678269);
			}

			// Token: 0x0600D2E4 RID: 53988 RVA: 0x00326B58 File Offset: 0x00324D58
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Override() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.Override.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2E5 RID: 53989 RVA: 0x00066A77 File Offset: 0x00064C77
			public Override(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700416A RID: 16746
			// (get) Token: 0x0600D2E6 RID: 53990 RVA: 0x00326B94 File Offset: 0x00324D94
			// (set) Token: 0x0600D2E7 RID: 53991 RVA: 0x00066A80 File Offset: 0x00064C80
			public unsafe float Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Value)) = value;
				}
			}

			// Token: 0x1700416B RID: 16747
			// (get) Token: 0x0600D2E8 RID: 53992 RVA: 0x00326BBC File Offset: 0x00324DBC
			// (set) Token: 0x0600D2E9 RID: 53993 RVA: 0x00066A9B File Offset: 0x00064C9B
			public unsafe int Priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Priority)) = value;
				}
			}

			// Token: 0x1700416C RID: 16748
			// (get) Token: 0x0600D2EA RID: 53994 RVA: 0x00326BE4 File Offset: 0x00324DE4
			// (set) Token: 0x0600D2EB RID: 53995 RVA: 0x00066AB6 File Offset: 0x00064CB6
			public unsafe string Label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008E26 RID: 36390
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04008E27 RID: 36391
			private static readonly IntPtr NativeFieldInfoPtr_Priority;

			// Token: 0x04008E28 RID: 36392
			private static readonly IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x04008E29 RID: 36393
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A9E RID: 2718
		[ObfuscatedName("ScheduleOne.Tools.FloatSmoother+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600D2EC RID: 53996 RVA: 0x00326C0C File Offset: 0x00324E0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr);
				FloatSmoother.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, "<>9");
				FloatSmoother.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, "<>9__17_1");
				FloatSmoother.__c.NativeFieldInfoPtr___9__18_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, "<>9__18_1");
				FloatSmoother.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, 100678271);
				FloatSmoother.__c.NativeMethodInfoPtr__AddOverride_b__17_1_Internal_Int32_Override_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, 100678272);
				FloatSmoother.__c.NativeMethodInfoPtr__RemoveOverride_b__18_1_Internal_Int32_Override_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, 100678273);
			}

			// Token: 0x0600D2ED RID: 53997 RVA: 0x00326CB0 File Offset: 0x00324EB0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2EE RID: 53998 RVA: 0x00326CEC File Offset: 0x00324EEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230969, XrefRangeEnd = 230971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AddOverride_b__17_1(FloatSmoother.Override x, FloatSmoother.Override y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c.NativeMethodInfoPtr__AddOverride_b__17_1_Internal_Int32_Override_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D2EF RID: 53999 RVA: 0x00326D4C File Offset: 0x00324F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RemoveOverride_b__18_1(FloatSmoother.Override x, FloatSmoother.Override y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c.NativeMethodInfoPtr__RemoveOverride_b__18_1_Internal_Int32_Override_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D2F0 RID: 54000 RVA: 0x00066AD5 File Offset: 0x00064CD5
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700416D RID: 16749
			// (get) Token: 0x0600D2F1 RID: 54001 RVA: 0x00326DAC File Offset: 0x00324FAC
			// (set) Token: 0x0600D2F2 RID: 54002 RVA: 0x00066ADE File Offset: 0x00064CDE
			public unsafe static FloatSmoother.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FloatSmoother.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FloatSmoother.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700416E RID: 16750
			// (get) Token: 0x0600D2F3 RID: 54003 RVA: 0x00326DD4 File Offset: 0x00324FD4
			// (set) Token: 0x0600D2F4 RID: 54004 RVA: 0x00066AF0 File Offset: 0x00064CF0
			public unsafe static Comparison<FloatSmoother.Override> __9__17_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FloatSmoother.__c.NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<FloatSmoother.Override>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FloatSmoother.__c.NativeFieldInfoPtr___9__17_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700416F RID: 16751
			// (get) Token: 0x0600D2F5 RID: 54005 RVA: 0x00326DFC File Offset: 0x00324FFC
			// (set) Token: 0x0600D2F6 RID: 54006 RVA: 0x00066B02 File Offset: 0x00064D02
			public unsafe static Comparison<FloatSmoother.Override> __9__18_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FloatSmoother.__c.NativeFieldInfoPtr___9__18_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<FloatSmoother.Override>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FloatSmoother.__c.NativeFieldInfoPtr___9__18_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E2A RID: 36394
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008E2B RID: 36395
			private static readonly IntPtr NativeFieldInfoPtr___9__17_1;

			// Token: 0x04008E2C RID: 36396
			private static readonly IntPtr NativeFieldInfoPtr___9__18_1;

			// Token: 0x04008E2D RID: 36397
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E2E RID: 36398
			private static readonly IntPtr NativeMethodInfoPtr__AddOverride_b__17_1_Internal_Int32_Override_Override_0;

			// Token: 0x04008E2F RID: 36399
			private static readonly IntPtr NativeMethodInfoPtr__RemoveOverride_b__18_1_Internal_Int32_Override_Override_0;
		}

		// Token: 0x02000A9F RID: 2719
		[ObfuscatedName("ScheduleOne.Tools.FloatSmoother+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x0600D2F7 RID: 54007 RVA: 0x00326E24 File Offset: 0x00325024
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr);
				FloatSmoother.__c__DisplayClass17_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr, "label");
				FloatSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr, 100678274);
				FloatSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr, 100678275);
			}

			// Token: 0x0600D2F8 RID: 54008 RVA: 0x00326E8C File Offset: 0x0032508C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2F9 RID: 54009 RVA: 0x00326EC8 File Offset: 0x003250C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230971, XrefRangeEnd = 230975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddOverride_b__0(FloatSmoother.Override x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D2FA RID: 54010 RVA: 0x00066B14 File Offset: 0x00064D14
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004170 RID: 16752
			// (get) Token: 0x0600D2FB RID: 54011 RVA: 0x00326F18 File Offset: 0x00325118
			// (set) Token: 0x0600D2FC RID: 54012 RVA: 0x00066B1D File Offset: 0x00064D1D
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.__c__DisplayClass17_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.__c__DisplayClass17_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008E30 RID: 36400
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04008E31 RID: 36401
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E32 RID: 36402
			private static readonly IntPtr NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0;
		}

		// Token: 0x02000AA0 RID: 2720
		[ObfuscatedName("ScheduleOne.Tools.FloatSmoother+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Object
		{
			// Token: 0x0600D2FD RID: 54013 RVA: 0x00326F40 File Offset: 0x00325140
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr);
				FloatSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr, "label");
				FloatSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr, 100678276);
				FloatSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr, 100678277);
			}

			// Token: 0x0600D2FE RID: 54014 RVA: 0x00326FA8 File Offset: 0x003251A8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2FF RID: 54015 RVA: 0x00326FE4 File Offset: 0x003251E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveOverride_b__0(FloatSmoother.Override x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D300 RID: 54016 RVA: 0x00066B3C File Offset: 0x00064D3C
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004171 RID: 16753
			// (get) Token: 0x0600D301 RID: 54017 RVA: 0x00327034 File Offset: 0x00325234
			// (set) Token: 0x0600D302 RID: 54018 RVA: 0x00066B45 File Offset: 0x00064D45
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008E33 RID: 36403
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04008E34 RID: 36404
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E35 RID: 36405
			private static readonly IntPtr NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0;
		}
	}
}
