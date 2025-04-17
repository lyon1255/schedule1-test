using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200065B RID: 1627
	public class PlayerEnergyUI : Singleton<PlayerEnergyUI>
	{
		// Token: 0x06009131 RID: 37169 RVA: 0x002586A0 File Offset: 0x002568A0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerEnergyUI()
		{
			Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PlayerEnergyUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr);
			PlayerEnergyUI.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "Slider");
			PlayerEnergyUI.NativeFieldInfoPtr_SliderRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "SliderRect");
			PlayerEnergyUI.NativeFieldInfoPtr_FillImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "FillImage");
			PlayerEnergyUI.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "Label");
			PlayerEnergyUI.NativeFieldInfoPtr_SliderColor_Green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "SliderColor_Green");
			PlayerEnergyUI.NativeFieldInfoPtr_SliderColor_Red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "SliderColor_Red");
			PlayerEnergyUI.NativeFieldInfoPtr_displayedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, "displayedValue");
			PlayerEnergyUI.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, 100681286);
			PlayerEnergyUI.NativeMethodInfoPtr_UpdateDisplayedEnergy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, 100681287);
			PlayerEnergyUI.NativeMethodInfoPtr_SetDisplayedEnergy_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, 100681288);
			PlayerEnergyUI.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, 100681289);
			PlayerEnergyUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, 100681290);
			PlayerEnergyUI.NativeMethodInfoPtr__Awake_b__7_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr, 100681291);
		}

		// Token: 0x06009132 RID: 37170 RVA: 0x002587D4 File Offset: 0x002569D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262504, XrefRangeEnd = 262527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEnergyUI.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009133 RID: 37171 RVA: 0x00258810 File Offset: 0x00256A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262527, XrefRangeEnd = 262532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDisplayedEnergy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergyUI.NativeMethodInfoPtr_UpdateDisplayedEnergy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009134 RID: 37172 RVA: 0x00258844 File Offset: 0x00256A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262532, XrefRangeEnd = 262533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedEnergy(float energy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref energy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergyUI.NativeMethodInfoPtr_SetDisplayedEnergy_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009135 RID: 37173 RVA: 0x00258884 File Offset: 0x00256A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262533, XrefRangeEnd = 262536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEnergyUI.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009136 RID: 37174 RVA: 0x002588C0 File Offset: 0x00256AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262536, XrefRangeEnd = 262539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerEnergyUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEnergyUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergyUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009137 RID: 37175 RVA: 0x002588FC File Offset: 0x00256AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262539, XrefRangeEnd = 262556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__7_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergyUI.NativeMethodInfoPtr__Awake_b__7_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009138 RID: 37176 RVA: 0x000462C6 File Offset: 0x000444C6
		public PlayerEnergyUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C7D RID: 11389
		// (get) Token: 0x06009139 RID: 37177 RVA: 0x00258930 File Offset: 0x00256B30
		// (set) Token: 0x0600913A RID: 37178 RVA: 0x000462CF File Offset: 0x000444CF
		public unsafe Slider Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C7E RID: 11390
		// (get) Token: 0x0600913B RID: 37179 RVA: 0x00258960 File Offset: 0x00256B60
		// (set) Token: 0x0600913C RID: 37180 RVA: 0x000462EE File Offset: 0x000444EE
		public unsafe RectTransform SliderRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_SliderRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_SliderRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C7F RID: 11391
		// (get) Token: 0x0600913D RID: 37181 RVA: 0x00258990 File Offset: 0x00256B90
		// (set) Token: 0x0600913E RID: 37182 RVA: 0x0004630D File Offset: 0x0004450D
		public unsafe Image FillImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_FillImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_FillImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C80 RID: 11392
		// (get) Token: 0x0600913F RID: 37183 RVA: 0x002589C0 File Offset: 0x00256BC0
		// (set) Token: 0x06009140 RID: 37184 RVA: 0x0004632C File Offset: 0x0004452C
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C81 RID: 11393
		// (get) Token: 0x06009141 RID: 37185 RVA: 0x002589F0 File Offset: 0x00256BF0
		// (set) Token: 0x06009142 RID: 37186 RVA: 0x0004634B File Offset: 0x0004454B
		public unsafe Color SliderColor_Green
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_SliderColor_Green);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_SliderColor_Green)) = value;
			}
		}

		// Token: 0x17002C82 RID: 11394
		// (get) Token: 0x06009143 RID: 37187 RVA: 0x00258A18 File Offset: 0x00256C18
		// (set) Token: 0x06009144 RID: 37188 RVA: 0x00046366 File Offset: 0x00044566
		public unsafe Color SliderColor_Red
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_SliderColor_Red);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_SliderColor_Red)) = value;
			}
		}

		// Token: 0x17002C83 RID: 11395
		// (get) Token: 0x06009145 RID: 37189 RVA: 0x00258A40 File Offset: 0x00256C40
		// (set) Token: 0x06009146 RID: 37190 RVA: 0x00046381 File Offset: 0x00044581
		public unsafe float displayedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_displayedValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergyUI.NativeFieldInfoPtr_displayedValue)) = value;
			}
		}

		// Token: 0x04006222 RID: 25122
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x04006223 RID: 25123
		private static readonly IntPtr NativeFieldInfoPtr_SliderRect;

		// Token: 0x04006224 RID: 25124
		private static readonly IntPtr NativeFieldInfoPtr_FillImage;

		// Token: 0x04006225 RID: 25125
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006226 RID: 25126
		private static readonly IntPtr NativeFieldInfoPtr_SliderColor_Green;

		// Token: 0x04006227 RID: 25127
		private static readonly IntPtr NativeFieldInfoPtr_SliderColor_Red;

		// Token: 0x04006228 RID: 25128
		private static readonly IntPtr NativeFieldInfoPtr_displayedValue;

		// Token: 0x04006229 RID: 25129
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400622A RID: 25130
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplayedEnergy_Private_Void_0;

		// Token: 0x0400622B RID: 25131
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedEnergy_Public_Void_Single_0;

		// Token: 0x0400622C RID: 25132
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400622D RID: 25133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400622E RID: 25134
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__7_0_Private_Void_0;
	}
}
