using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200053C RID: 1340
	[Serializable]
	public class HDRColorSmoother : Il2CppSystem.Object
	{
		// Token: 0x060076EF RID: 30447 RVA: 0x00204980 File Offset: 0x00202B80
		// Note: this type is marked as 'beforefieldinit'.
		static HDRColorSmoother()
		{
			Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "HDRColorSmoother");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr);
			HDRColorSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, "<CurrentValue>k__BackingField");
			HDRColorSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, "<Multiplier>k__BackingField");
			HDRColorSmoother.NativeFieldInfoPtr_DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, "DefaultValue");
			HDRColorSmoother.NativeFieldInfoPtr_SmoothingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, "SmoothingSpeed");
			HDRColorSmoother.NativeFieldInfoPtr_overrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, "overrides");
			HDRColorSmoother.NativeMethodInfoPtr_get_CurrentValue_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678282);
			HDRColorSmoother.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678283);
			HDRColorSmoother.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678284);
			HDRColorSmoother.NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678285);
			HDRColorSmoother.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678286);
			HDRColorSmoother.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678287);
			HDRColorSmoother.NativeMethodInfoPtr_SetDefault_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678288);
			HDRColorSmoother.NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678289);
			HDRColorSmoother.NativeMethodInfoPtr_AddOverride_Public_Void_Color_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678290);
			HDRColorSmoother.NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678291);
			HDRColorSmoother.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678292);
			HDRColorSmoother.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678293);
		}

		// Token: 0x170023FF RID: 9215
		// (get) Token: 0x060076F0 RID: 30448 RVA: 0x00204B04 File Offset: 0x00202D04
		// (set) Token: 0x060076F1 RID: 30449 RVA: 0x00204B40 File Offset: 0x00202D40
		public unsafe Color CurrentValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29960, RefRangeEnd = 29961, XrefRangeStart = 29960, XrefRangeEnd = 29961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_get_CurrentValue_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002400 RID: 9216
		// (get) Token: 0x060076F2 RID: 30450 RVA: 0x00204B80 File Offset: 0x00202D80
		// (set) Token: 0x060076F3 RID: 30451 RVA: 0x00204BBC File Offset: 0x00202DBC
		public unsafe float Multiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29961, RefRangeEnd = 29962, XrefRangeStart = 29961, XrefRangeEnd = 29962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060076F4 RID: 30452 RVA: 0x00204BFC File Offset: 0x00202DFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 231233, RefRangeEnd = 231234, XrefRangeStart = 231212, XrefRangeEnd = 231233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076F5 RID: 30453 RVA: 0x00204C30 File Offset: 0x00202E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231234, XrefRangeEnd = 231252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076F6 RID: 30454 RVA: 0x00204C64 File Offset: 0x00202E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231252, XrefRangeEnd = 231255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefault(Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_SetDefault_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076F7 RID: 30455 RVA: 0x00204CA4 File Offset: 0x00202EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29961, RefRangeEnd = 29962, XrefRangeStart = 29961, XrefRangeEnd = 29962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMultiplier(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076F8 RID: 30456 RVA: 0x00204CE4 File Offset: 0x00202EE4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 231299, RefRangeEnd = 231305, XrefRangeStart = 231255, XrefRangeEnd = 231299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOverride(Color value, int priority, string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_AddOverride_Public_Void_Color_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076F9 RID: 30457 RVA: 0x00204D44 File Offset: 0x00202F44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 231341, RefRangeEnd = 231345, XrefRangeStart = 231305, XrefRangeEnd = 231341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOverride(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076FA RID: 30458 RVA: 0x00204D88 File Offset: 0x00202F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231345, XrefRangeEnd = 231351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076FB RID: 30459 RVA: 0x00204DBC File Offset: 0x00202FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231351, XrefRangeEnd = 231359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HDRColorSmoother() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076FC RID: 30460 RVA: 0x0003855A File Offset: 0x0003675A
		public HDRColorSmoother(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023FA RID: 9210
		// (get) Token: 0x060076FD RID: 30461 RVA: 0x00204DF8 File Offset: 0x00202FF8
		// (set) Token: 0x060076FE RID: 30462 RVA: 0x00038563 File Offset: 0x00036763
		public unsafe Color _CurrentValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField)) = value;
			}
		}

		// Token: 0x170023FB RID: 9211
		// (get) Token: 0x060076FF RID: 30463 RVA: 0x00204E20 File Offset: 0x00203020
		// (set) Token: 0x06007700 RID: 30464 RVA: 0x0003857E File Offset: 0x0003677E
		public unsafe float _Multiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x170023FC RID: 9212
		// (get) Token: 0x06007701 RID: 30465 RVA: 0x00204E48 File Offset: 0x00203048
		// (set) Token: 0x06007702 RID: 30466 RVA: 0x00038599 File Offset: 0x00036799
		public unsafe Color DefaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr_DefaultValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr_DefaultValue)) = value;
			}
		}

		// Token: 0x170023FD RID: 9213
		// (get) Token: 0x06007703 RID: 30467 RVA: 0x00204E70 File Offset: 0x00203070
		// (set) Token: 0x06007704 RID: 30468 RVA: 0x000385B4 File Offset: 0x000367B4
		public unsafe float SmoothingSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr_SmoothingSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr_SmoothingSpeed)) = value;
			}
		}

		// Token: 0x170023FE RID: 9214
		// (get) Token: 0x06007705 RID: 30469 RVA: 0x00204E98 File Offset: 0x00203098
		// (set) Token: 0x06007706 RID: 30470 RVA: 0x000385CF File Offset: 0x000367CF
		public unsafe List<HDRColorSmoother.Override> overrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr_overrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HDRColorSmoother.Override>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr_overrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005133 RID: 20787
		private static readonly IntPtr NativeFieldInfoPtr__CurrentValue_k__BackingField;

		// Token: 0x04005134 RID: 20788
		private static readonly IntPtr NativeFieldInfoPtr__Multiplier_k__BackingField;

		// Token: 0x04005135 RID: 20789
		private static readonly IntPtr NativeFieldInfoPtr_DefaultValue;

		// Token: 0x04005136 RID: 20790
		private static readonly IntPtr NativeFieldInfoPtr_SmoothingSpeed;

		// Token: 0x04005137 RID: 20791
		private static readonly IntPtr NativeFieldInfoPtr_overrides;

		// Token: 0x04005138 RID: 20792
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_get_Color_0;

		// Token: 0x04005139 RID: 20793
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Color_0;

		// Token: 0x0400513A RID: 20794
		private static readonly IntPtr NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0;

		// Token: 0x0400513B RID: 20795
		private static readonly IntPtr NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0;

		// Token: 0x0400513C RID: 20796
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x0400513D RID: 20797
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x0400513E RID: 20798
		private static readonly IntPtr NativeMethodInfoPtr_SetDefault_Public_Void_Color_0;

		// Token: 0x0400513F RID: 20799
		private static readonly IntPtr NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0;

		// Token: 0x04005140 RID: 20800
		private static readonly IntPtr NativeMethodInfoPtr_AddOverride_Public_Void_Color_Int32_String_0;

		// Token: 0x04005141 RID: 20801
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0;

		// Token: 0x04005142 RID: 20802
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04005143 RID: 20803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AA1 RID: 2721
		[Serializable]
		public class Override : Il2CppSystem.Object
		{
			// Token: 0x0600D303 RID: 54019 RVA: 0x0032705C File Offset: 0x0032525C
			// Note: this type is marked as 'beforefieldinit'.
			static Override()
			{
				Il2CppClassPointerStore<HDRColorSmoother.Override>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, "Override");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDRColorSmoother.Override>.NativeClassPtr);
				HDRColorSmoother.Override.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother.Override>.NativeClassPtr, "Value");
				HDRColorSmoother.Override.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother.Override>.NativeClassPtr, "Priority");
				HDRColorSmoother.Override.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother.Override>.NativeClassPtr, "Label");
				HDRColorSmoother.Override.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother.Override>.NativeClassPtr, 100678294);
			}

			// Token: 0x0600D304 RID: 54020 RVA: 0x003270D8 File Offset: 0x003252D8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Override() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDRColorSmoother.Override>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.Override.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D305 RID: 54021 RVA: 0x00066B64 File Offset: 0x00064D64
			public Override(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004172 RID: 16754
			// (get) Token: 0x0600D306 RID: 54022 RVA: 0x00327114 File Offset: 0x00325314
			// (set) Token: 0x0600D307 RID: 54023 RVA: 0x00066B6D File Offset: 0x00064D6D
			public unsafe Color Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.Override.NativeFieldInfoPtr_Value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.Override.NativeFieldInfoPtr_Value)) = value;
				}
			}

			// Token: 0x17004173 RID: 16755
			// (get) Token: 0x0600D308 RID: 54024 RVA: 0x0032713C File Offset: 0x0032533C
			// (set) Token: 0x0600D309 RID: 54025 RVA: 0x00066B88 File Offset: 0x00064D88
			public unsafe int Priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.Override.NativeFieldInfoPtr_Priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.Override.NativeFieldInfoPtr_Priority)) = value;
				}
			}

			// Token: 0x17004174 RID: 16756
			// (get) Token: 0x0600D30A RID: 54026 RVA: 0x00327164 File Offset: 0x00325364
			// (set) Token: 0x0600D30B RID: 54027 RVA: 0x00066BA3 File Offset: 0x00064DA3
			public unsafe string Label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.Override.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.Override.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008E36 RID: 36406
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04008E37 RID: 36407
			private static readonly IntPtr NativeFieldInfoPtr_Priority;

			// Token: 0x04008E38 RID: 36408
			private static readonly IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x04008E39 RID: 36409
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AA2 RID: 2722
		[ObfuscatedName("ScheduleOne.Tools.HDRColorSmoother+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D30C RID: 54028 RVA: 0x0032718C File Offset: 0x0032538C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HDRColorSmoother.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDRColorSmoother.__c>.NativeClassPtr);
				HDRColorSmoother.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother.__c>.NativeClassPtr, "<>9");
				HDRColorSmoother.__c.NativeFieldInfoPtr___9__16_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother.__c>.NativeClassPtr, "<>9__16_1");
				HDRColorSmoother.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother.__c>.NativeClassPtr, "<>9__17_1");
				HDRColorSmoother.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother.__c>.NativeClassPtr, 100678296);
				HDRColorSmoother.__c.NativeMethodInfoPtr__AddOverride_b__16_1_Internal_Int32_Override_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother.__c>.NativeClassPtr, 100678297);
				HDRColorSmoother.__c.NativeMethodInfoPtr__RemoveOverride_b__17_1_Internal_Int32_Override_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother.__c>.NativeClassPtr, 100678298);
			}

			// Token: 0x0600D30D RID: 54029 RVA: 0x00327230 File Offset: 0x00325430
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDRColorSmoother.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D30E RID: 54030 RVA: 0x0032726C File Offset: 0x0032546C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AddOverride_b__16_1(HDRColorSmoother.Override x, HDRColorSmoother.Override y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.__c.NativeMethodInfoPtr__AddOverride_b__16_1_Internal_Int32_Override_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D30F RID: 54031 RVA: 0x003272CC File Offset: 0x003254CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RemoveOverride_b__17_1(HDRColorSmoother.Override x, HDRColorSmoother.Override y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.__c.NativeMethodInfoPtr__RemoveOverride_b__17_1_Internal_Int32_Override_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D310 RID: 54032 RVA: 0x00066BC2 File Offset: 0x00064DC2
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004175 RID: 16757
			// (get) Token: 0x0600D311 RID: 54033 RVA: 0x0032732C File Offset: 0x0032552C
			// (set) Token: 0x0600D312 RID: 54034 RVA: 0x00066BCB File Offset: 0x00064DCB
			public unsafe static HDRColorSmoother.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HDRColorSmoother.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HDRColorSmoother.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDRColorSmoother.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004176 RID: 16758
			// (get) Token: 0x0600D313 RID: 54035 RVA: 0x00327354 File Offset: 0x00325554
			// (set) Token: 0x0600D314 RID: 54036 RVA: 0x00066BDD File Offset: 0x00064DDD
			public unsafe static Comparison<HDRColorSmoother.Override> __9__16_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HDRColorSmoother.__c.NativeFieldInfoPtr___9__16_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<HDRColorSmoother.Override>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDRColorSmoother.__c.NativeFieldInfoPtr___9__16_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004177 RID: 16759
			// (get) Token: 0x0600D315 RID: 54037 RVA: 0x0032737C File Offset: 0x0032557C
			// (set) Token: 0x0600D316 RID: 54038 RVA: 0x00066BEF File Offset: 0x00064DEF
			public unsafe static Comparison<HDRColorSmoother.Override> __9__17_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HDRColorSmoother.__c.NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<HDRColorSmoother.Override>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDRColorSmoother.__c.NativeFieldInfoPtr___9__17_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E3A RID: 36410
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008E3B RID: 36411
			private static readonly IntPtr NativeFieldInfoPtr___9__16_1;

			// Token: 0x04008E3C RID: 36412
			private static readonly IntPtr NativeFieldInfoPtr___9__17_1;

			// Token: 0x04008E3D RID: 36413
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E3E RID: 36414
			private static readonly IntPtr NativeMethodInfoPtr__AddOverride_b__16_1_Internal_Int32_Override_Override_0;

			// Token: 0x04008E3F RID: 36415
			private static readonly IntPtr NativeMethodInfoPtr__RemoveOverride_b__17_1_Internal_Int32_Override_Override_0;
		}

		// Token: 0x02000AA3 RID: 2723
		[ObfuscatedName("ScheduleOne.Tools.HDRColorSmoother+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D317 RID: 54039 RVA: 0x003273A4 File Offset: 0x003255A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass16_0>.NativeClassPtr);
				HDRColorSmoother.__c__DisplayClass16_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass16_0>.NativeClassPtr, "label");
				HDRColorSmoother.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass16_0>.NativeClassPtr, 100678299);
				HDRColorSmoother.__c__DisplayClass16_0.NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass16_0>.NativeClassPtr, 100678300);
			}

			// Token: 0x0600D318 RID: 54040 RVA: 0x0032740C File Offset: 0x0032560C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D319 RID: 54041 RVA: 0x00327448 File Offset: 0x00325648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddOverride_b__0(HDRColorSmoother.Override x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.__c__DisplayClass16_0.NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D31A RID: 54042 RVA: 0x00066C01 File Offset: 0x00064E01
			public __c__DisplayClass16_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004178 RID: 16760
			// (get) Token: 0x0600D31B RID: 54043 RVA: 0x00327498 File Offset: 0x00325698
			// (set) Token: 0x0600D31C RID: 54044 RVA: 0x00066C0A File Offset: 0x00064E0A
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.__c__DisplayClass16_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.__c__DisplayClass16_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008E40 RID: 36416
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04008E41 RID: 36417
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E42 RID: 36418
			private static readonly IntPtr NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0;
		}

		// Token: 0x02000AA4 RID: 2724
		[ObfuscatedName("ScheduleOne.Tools.HDRColorSmoother+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D31D RID: 54045 RVA: 0x003274C0 File Offset: 0x003256C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass17_0>.NativeClassPtr);
				HDRColorSmoother.__c__DisplayClass17_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass17_0>.NativeClassPtr, "label");
				HDRColorSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass17_0>.NativeClassPtr, 100678301);
				HDRColorSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass17_0>.NativeClassPtr, 100678302);
			}

			// Token: 0x0600D31E RID: 54046 RVA: 0x00327528 File Offset: 0x00325728
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D31F RID: 54047 RVA: 0x00327564 File Offset: 0x00325764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveOverride_b__0(HDRColorSmoother.Override x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D320 RID: 54048 RVA: 0x00066C29 File Offset: 0x00064E29
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004179 RID: 16761
			// (get) Token: 0x0600D321 RID: 54049 RVA: 0x003275B4 File Offset: 0x003257B4
			// (set) Token: 0x0600D322 RID: 54050 RVA: 0x00066C32 File Offset: 0x00064E32
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.__c__DisplayClass17_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.__c__DisplayClass17_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008E43 RID: 36419
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04008E44 RID: 36420
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E45 RID: 36421
			private static readonly IntPtr NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0;
		}
	}
}
