using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000131 RID: 305
	public class WeatherEnclosureDetector : MonoBehaviour
	{
		// Token: 0x060019FB RID: 6651 RVA: 0x000C1BD4 File Offset: 0x000BFDD4
		// Note: this type is marked as 'beforefieldinit'.
		static WeatherEnclosureDetector()
		{
			Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "WeatherEnclosureDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr);
			WeatherEnclosureDetector.NativeFieldInfoPtr_mainEnclosure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, "mainEnclosure");
			WeatherEnclosureDetector.NativeFieldInfoPtr_triggeredEnclosures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, "triggeredEnclosures");
			WeatherEnclosureDetector.NativeFieldInfoPtr_rainController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, "rainController");
			WeatherEnclosureDetector.NativeFieldInfoPtr_enclosureChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, "enclosureChangedCallback");
			WeatherEnclosureDetector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, 100666055);
			WeatherEnclosureDetector.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, 100666056);
			WeatherEnclosureDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, 100666057);
			WeatherEnclosureDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, 100666058);
			WeatherEnclosureDetector.NativeMethodInfoPtr_ApplyEnclosure_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, 100666059);
			WeatherEnclosureDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr, 100666060);
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x000C1CCC File Offset: 0x000BFECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96840, XrefRangeEnd = 96841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEnclosureDetector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x000C1D00 File Offset: 0x000BFF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEnclosureDetector.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x000C1D34 File Offset: 0x000BFF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96841, XrefRangeEnd = 96861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEnclosureDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x000C1D78 File Offset: 0x000BFF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96861, XrefRangeEnd = 96876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEnclosureDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x000C1DBC File Offset: 0x000BFFBC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 96890, RefRangeEnd = 96894, XrefRangeStart = 96876, XrefRangeEnd = 96890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEnclosure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEnclosureDetector.NativeMethodInfoPtr_ApplyEnclosure_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x000C1DF0 File Offset: 0x000BFFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96894, XrefRangeEnd = 96902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeatherEnclosureDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherEnclosureDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEnclosureDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x0000EC7B File Offset: 0x0000CE7B
		public WeatherEnclosureDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x000C1E2C File Offset: 0x000C002C
		// (set) Token: 0x06001A04 RID: 6660 RVA: 0x0000EC84 File Offset: 0x0000CE84
		public unsafe WeatherEnclosure mainEnclosure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosureDetector.NativeFieldInfoPtr_mainEnclosure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherEnclosure>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosureDetector.NativeFieldInfoPtr_mainEnclosure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001A05 RID: 6661 RVA: 0x000C1E5C File Offset: 0x000C005C
		// (set) Token: 0x06001A06 RID: 6662 RVA: 0x0000ECA3 File Offset: 0x0000CEA3
		public unsafe List<WeatherEnclosure> triggeredEnclosures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosureDetector.NativeFieldInfoPtr_triggeredEnclosures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeatherEnclosure>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosureDetector.NativeFieldInfoPtr_triggeredEnclosures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001A07 RID: 6663 RVA: 0x000C1E8C File Offset: 0x000C008C
		// (set) Token: 0x06001A08 RID: 6664 RVA: 0x0000ECC2 File Offset: 0x0000CEC2
		public unsafe RainDownfallController rainController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosureDetector.NativeFieldInfoPtr_rainController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RainDownfallController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosureDetector.NativeFieldInfoPtr_rainController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x000C1EBC File Offset: 0x000C00BC
		// (set) Token: 0x06001A0A RID: 6666 RVA: 0x0000ECE1 File Offset: 0x0000CEE1
		public unsafe Action<WeatherEnclosure> enclosureChangedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosureDetector.NativeFieldInfoPtr_enclosureChangedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<WeatherEnclosure>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosureDetector.NativeFieldInfoPtr_enclosureChangedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeFieldInfoPtr_mainEnclosure;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeFieldInfoPtr_triggeredEnclosures;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeFieldInfoPtr_rainController;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeFieldInfoPtr_enclosureChangedCallback;

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEnclosure_Public_Void_0;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
