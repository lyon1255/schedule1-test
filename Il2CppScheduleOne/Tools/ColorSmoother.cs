using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000530 RID: 1328
	[Serializable]
	public class ColorSmoother : Il2CppSystem.Object
	{
		// Token: 0x0600765F RID: 30303 RVA: 0x00202E08 File Offset: 0x00201008
		// Note: this type is marked as 'beforefieldinit'.
		static ColorSmoother()
		{
			Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ColorSmoother");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr);
			ColorSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "<CurrentValue>k__BackingField");
			ColorSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "<Multiplier>k__BackingField");
			ColorSmoother.NativeFieldInfoPtr_DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "DefaultValue");
			ColorSmoother.NativeFieldInfoPtr_SmoothingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "SmoothingSpeed");
			ColorSmoother.NativeFieldInfoPtr_overrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "overrides");
			ColorSmoother.NativeMethodInfoPtr_get_CurrentValue_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678202);
			ColorSmoother.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678203);
			ColorSmoother.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678204);
			ColorSmoother.NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678205);
			ColorSmoother.NativeMethodInfoPtr_get_Default_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678206);
			ColorSmoother.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678207);
			ColorSmoother.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678208);
			ColorSmoother.NativeMethodInfoPtr_SetDefault_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678209);
			ColorSmoother.NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678210);
			ColorSmoother.NativeMethodInfoPtr_AddOverride_Public_Void_Color_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678211);
			ColorSmoother.NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678212);
			ColorSmoother.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678213);
			ColorSmoother.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678214);
		}

		// Token: 0x170023DA RID: 9178
		// (get) Token: 0x06007660 RID: 30304 RVA: 0x00202FA0 File Offset: 0x002011A0
		// (set) Token: 0x06007661 RID: 30305 RVA: 0x00202FDC File Offset: 0x002011DC
		public unsafe Color CurrentValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29960, RefRangeEnd = 29961, XrefRangeStart = 29960, XrefRangeEnd = 29961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_get_CurrentValue_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170023DB RID: 9179
		// (get) Token: 0x06007662 RID: 30306 RVA: 0x0020301C File Offset: 0x0020121C
		// (set) Token: 0x06007663 RID: 30307 RVA: 0x00203058 File Offset: 0x00201258
		public unsafe float Multiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170023DC RID: 9180
		// (get) Token: 0x06007664 RID: 30308 RVA: 0x00203098 File Offset: 0x00201298
		public unsafe Color Default
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_get_Default_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007665 RID: 30309 RVA: 0x002030D4 File Offset: 0x002012D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230689, RefRangeEnd = 230690, XrefRangeStart = 230668, XrefRangeEnd = 230689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007666 RID: 30310 RVA: 0x00203108 File Offset: 0x00201308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230690, XrefRangeEnd = 230708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007667 RID: 30311 RVA: 0x0020313C File Offset: 0x0020133C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230711, RefRangeEnd = 230712, XrefRangeStart = 230708, XrefRangeEnd = 230711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefault(Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_SetDefault_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007668 RID: 30312 RVA: 0x0020317C File Offset: 0x0020137C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29961, RefRangeEnd = 29962, XrefRangeStart = 29961, XrefRangeEnd = 29962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMultiplier(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007669 RID: 30313 RVA: 0x002031BC File Offset: 0x002013BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 230756, RefRangeEnd = 230761, XrefRangeStart = 230712, XrefRangeEnd = 230756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOverride(Color value, int priority, string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_AddOverride_Public_Void_Color_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600766A RID: 30314 RVA: 0x0020321C File Offset: 0x0020141C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 230797, RefRangeEnd = 230799, XrefRangeStart = 230761, XrefRangeEnd = 230797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOverride(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600766B RID: 30315 RVA: 0x00203260 File Offset: 0x00201460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230799, XrefRangeEnd = 230805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600766C RID: 30316 RVA: 0x00203294 File Offset: 0x00201494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230805, XrefRangeEnd = 230813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorSmoother() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600766D RID: 30317 RVA: 0x00038162 File Offset: 0x00036362
		public ColorSmoother(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023D5 RID: 9173
		// (get) Token: 0x0600766E RID: 30318 RVA: 0x002032D0 File Offset: 0x002014D0
		// (set) Token: 0x0600766F RID: 30319 RVA: 0x0003816B File Offset: 0x0003636B
		public unsafe Color _CurrentValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField)) = value;
			}
		}

		// Token: 0x170023D6 RID: 9174
		// (get) Token: 0x06007670 RID: 30320 RVA: 0x002032F8 File Offset: 0x002014F8
		// (set) Token: 0x06007671 RID: 30321 RVA: 0x00038186 File Offset: 0x00036386
		public unsafe float _Multiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x170023D7 RID: 9175
		// (get) Token: 0x06007672 RID: 30322 RVA: 0x00203320 File Offset: 0x00201520
		// (set) Token: 0x06007673 RID: 30323 RVA: 0x000381A1 File Offset: 0x000363A1
		public unsafe Color DefaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr_DefaultValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr_DefaultValue)) = value;
			}
		}

		// Token: 0x170023D8 RID: 9176
		// (get) Token: 0x06007674 RID: 30324 RVA: 0x00203348 File Offset: 0x00201548
		// (set) Token: 0x06007675 RID: 30325 RVA: 0x000381BC File Offset: 0x000363BC
		public unsafe float SmoothingSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr_SmoothingSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr_SmoothingSpeed)) = value;
			}
		}

		// Token: 0x170023D9 RID: 9177
		// (get) Token: 0x06007676 RID: 30326 RVA: 0x00203370 File Offset: 0x00201570
		// (set) Token: 0x06007677 RID: 30327 RVA: 0x000381D7 File Offset: 0x000363D7
		public unsafe List<ColorSmoother.Override> overrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr_overrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ColorSmoother.Override>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr_overrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040050DB RID: 20699
		private static readonly IntPtr NativeFieldInfoPtr__CurrentValue_k__BackingField;

		// Token: 0x040050DC RID: 20700
		private static readonly IntPtr NativeFieldInfoPtr__Multiplier_k__BackingField;

		// Token: 0x040050DD RID: 20701
		private static readonly IntPtr NativeFieldInfoPtr_DefaultValue;

		// Token: 0x040050DE RID: 20702
		private static readonly IntPtr NativeFieldInfoPtr_SmoothingSpeed;

		// Token: 0x040050DF RID: 20703
		private static readonly IntPtr NativeFieldInfoPtr_overrides;

		// Token: 0x040050E0 RID: 20704
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_get_Color_0;

		// Token: 0x040050E1 RID: 20705
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Color_0;

		// Token: 0x040050E2 RID: 20706
		private static readonly IntPtr NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0;

		// Token: 0x040050E3 RID: 20707
		private static readonly IntPtr NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0;

		// Token: 0x040050E4 RID: 20708
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_get_Color_0;

		// Token: 0x040050E5 RID: 20709
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x040050E6 RID: 20710
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x040050E7 RID: 20711
		private static readonly IntPtr NativeMethodInfoPtr_SetDefault_Public_Void_Color_0;

		// Token: 0x040050E8 RID: 20712
		private static readonly IntPtr NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0;

		// Token: 0x040050E9 RID: 20713
		private static readonly IntPtr NativeMethodInfoPtr_AddOverride_Public_Void_Color_Int32_String_0;

		// Token: 0x040050EA RID: 20714
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0;

		// Token: 0x040050EB RID: 20715
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040050EC RID: 20716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A97 RID: 2711
		[Serializable]
		public class Override : Il2CppSystem.Object
		{
			// Token: 0x0600D2B5 RID: 53941 RVA: 0x00326288 File Offset: 0x00324488
			// Note: this type is marked as 'beforefieldinit'.
			static Override()
			{
				Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "Override");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr);
				ColorSmoother.Override.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr, "Value");
				ColorSmoother.Override.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr, "Priority");
				ColorSmoother.Override.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr, "Label");
				ColorSmoother.Override.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr, 100678215);
			}

			// Token: 0x0600D2B6 RID: 53942 RVA: 0x00326304 File Offset: 0x00324504
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Override() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.Override.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2B7 RID: 53943 RVA: 0x00066928 File Offset: 0x00064B28
			public Override(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700415D RID: 16733
			// (get) Token: 0x0600D2B8 RID: 53944 RVA: 0x00326340 File Offset: 0x00324540
			// (set) Token: 0x0600D2B9 RID: 53945 RVA: 0x00066931 File Offset: 0x00064B31
			public unsafe Color Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.Override.NativeFieldInfoPtr_Value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.Override.NativeFieldInfoPtr_Value)) = value;
				}
			}

			// Token: 0x1700415E RID: 16734
			// (get) Token: 0x0600D2BA RID: 53946 RVA: 0x00326368 File Offset: 0x00324568
			// (set) Token: 0x0600D2BB RID: 53947 RVA: 0x0006694C File Offset: 0x00064B4C
			public unsafe int Priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.Override.NativeFieldInfoPtr_Priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.Override.NativeFieldInfoPtr_Priority)) = value;
				}
			}

			// Token: 0x1700415F RID: 16735
			// (get) Token: 0x0600D2BC RID: 53948 RVA: 0x00326390 File Offset: 0x00324590
			// (set) Token: 0x0600D2BD RID: 53949 RVA: 0x00066967 File Offset: 0x00064B67
			public unsafe string Label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.Override.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.Override.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008E0A RID: 36362
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04008E0B RID: 36363
			private static readonly IntPtr NativeFieldInfoPtr_Priority;

			// Token: 0x04008E0C RID: 36364
			private static readonly IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x04008E0D RID: 36365
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A98 RID: 2712
		[ObfuscatedName("ScheduleOne.Tools.ColorSmoother+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D2BE RID: 53950 RVA: 0x003263B8 File Offset: 0x003245B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr);
				ColorSmoother.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr, "<>9");
				ColorSmoother.__c.NativeFieldInfoPtr___9__18_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr, "<>9__18_1");
				ColorSmoother.__c.NativeFieldInfoPtr___9__19_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr, "<>9__19_1");
				ColorSmoother.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr, 100678217);
				ColorSmoother.__c.NativeMethodInfoPtr__AddOverride_b__18_1_Internal_Int32_Override_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr, 100678218);
				ColorSmoother.__c.NativeMethodInfoPtr__RemoveOverride_b__19_1_Internal_Int32_Override_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr, 100678219);
			}

			// Token: 0x0600D2BF RID: 53951 RVA: 0x0032645C File Offset: 0x0032465C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2C0 RID: 53952 RVA: 0x00326498 File Offset: 0x00324698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230662, XrefRangeEnd = 230664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AddOverride_b__18_1(ColorSmoother.Override x, ColorSmoother.Override y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c.NativeMethodInfoPtr__AddOverride_b__18_1_Internal_Int32_Override_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D2C1 RID: 53953 RVA: 0x003264F8 File Offset: 0x003246F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RemoveOverride_b__19_1(ColorSmoother.Override x, ColorSmoother.Override y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c.NativeMethodInfoPtr__RemoveOverride_b__19_1_Internal_Int32_Override_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D2C2 RID: 53954 RVA: 0x00066986 File Offset: 0x00064B86
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004160 RID: 16736
			// (get) Token: 0x0600D2C3 RID: 53955 RVA: 0x00326558 File Offset: 0x00324758
			// (set) Token: 0x0600D2C4 RID: 53956 RVA: 0x0006698F File Offset: 0x00064B8F
			public unsafe static ColorSmoother.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ColorSmoother.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorSmoother.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorSmoother.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004161 RID: 16737
			// (get) Token: 0x0600D2C5 RID: 53957 RVA: 0x00326580 File Offset: 0x00324780
			// (set) Token: 0x0600D2C6 RID: 53958 RVA: 0x000669A1 File Offset: 0x00064BA1
			public unsafe static Comparison<ColorSmoother.Override> __9__18_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ColorSmoother.__c.NativeFieldInfoPtr___9__18_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ColorSmoother.Override>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorSmoother.__c.NativeFieldInfoPtr___9__18_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004162 RID: 16738
			// (get) Token: 0x0600D2C7 RID: 53959 RVA: 0x003265A8 File Offset: 0x003247A8
			// (set) Token: 0x0600D2C8 RID: 53960 RVA: 0x000669B3 File Offset: 0x00064BB3
			public unsafe static Comparison<ColorSmoother.Override> __9__19_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ColorSmoother.__c.NativeFieldInfoPtr___9__19_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ColorSmoother.Override>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorSmoother.__c.NativeFieldInfoPtr___9__19_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E0E RID: 36366
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008E0F RID: 36367
			private static readonly IntPtr NativeFieldInfoPtr___9__18_1;

			// Token: 0x04008E10 RID: 36368
			private static readonly IntPtr NativeFieldInfoPtr___9__19_1;

			// Token: 0x04008E11 RID: 36369
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E12 RID: 36370
			private static readonly IntPtr NativeMethodInfoPtr__AddOverride_b__18_1_Internal_Int32_Override_Override_0;

			// Token: 0x04008E13 RID: 36371
			private static readonly IntPtr NativeMethodInfoPtr__RemoveOverride_b__19_1_Internal_Int32_Override_Override_0;
		}

		// Token: 0x02000A99 RID: 2713
		[ObfuscatedName("ScheduleOne.Tools.ColorSmoother+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D2C9 RID: 53961 RVA: 0x003265D0 File Offset: 0x003247D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass18_0>.NativeClassPtr);
				ColorSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass18_0>.NativeClassPtr, "label");
				ColorSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass18_0>.NativeClassPtr, 100678220);
				ColorSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass18_0>.NativeClassPtr, 100678221);
			}

			// Token: 0x0600D2CA RID: 53962 RVA: 0x00326638 File Offset: 0x00324838
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2CB RID: 53963 RVA: 0x00326674 File Offset: 0x00324874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230664, XrefRangeEnd = 230668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddOverride_b__0(ColorSmoother.Override x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D2CC RID: 53964 RVA: 0x000669C5 File Offset: 0x00064BC5
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004163 RID: 16739
			// (get) Token: 0x0600D2CD RID: 53965 RVA: 0x003266C4 File Offset: 0x003248C4
			// (set) Token: 0x0600D2CE RID: 53966 RVA: 0x000669CE File Offset: 0x00064BCE
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008E14 RID: 36372
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04008E15 RID: 36373
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E16 RID: 36374
			private static readonly IntPtr NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0;
		}

		// Token: 0x02000A9A RID: 2714
		[ObfuscatedName("ScheduleOne.Tools.ColorSmoother+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D2CF RID: 53967 RVA: 0x003266EC File Offset: 0x003248EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass19_0>.NativeClassPtr);
				ColorSmoother.__c__DisplayClass19_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass19_0>.NativeClassPtr, "label");
				ColorSmoother.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass19_0>.NativeClassPtr, 100678222);
				ColorSmoother.__c__DisplayClass19_0.NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass19_0>.NativeClassPtr, 100678223);
			}

			// Token: 0x0600D2D0 RID: 53968 RVA: 0x00326754 File Offset: 0x00324954
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2D1 RID: 53969 RVA: 0x00326790 File Offset: 0x00324990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveOverride_b__0(ColorSmoother.Override x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c__DisplayClass19_0.NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D2D2 RID: 53970 RVA: 0x000669ED File Offset: 0x00064BED
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004164 RID: 16740
			// (get) Token: 0x0600D2D3 RID: 53971 RVA: 0x003267E0 File Offset: 0x003249E0
			// (set) Token: 0x0600D2D4 RID: 53972 RVA: 0x000669F6 File Offset: 0x00064BF6
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.__c__DisplayClass19_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.__c__DisplayClass19_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008E17 RID: 36375
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04008E18 RID: 36376
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E19 RID: 36377
			private static readonly IntPtr NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0;
		}
	}
}
