using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000665 RID: 1637
	public class RegionUnlockedCanvas : Singleton<RegionUnlockedCanvas>
	{
		// Token: 0x06009243 RID: 37443 RVA: 0x0025BBBC File Offset: 0x00259DBC
		// Note: this type is marked as 'beforefieldinit'.
		static RegionUnlockedCanvas()
		{
			Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "RegionUnlockedCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr);
			RegionUnlockedCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "<IsRunning>k__BackingField");
			RegionUnlockedCanvas.NativeFieldInfoPtr__Order_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "<Order>k__BackingField");
			RegionUnlockedCanvas.NativeFieldInfoPtr_OpenCloseAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "OpenCloseAnim");
			RegionUnlockedCanvas.NativeFieldInfoPtr_RegionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "RegionLabel");
			RegionUnlockedCanvas.NativeFieldInfoPtr_RegionDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "RegionDescription");
			RegionUnlockedCanvas.NativeFieldInfoPtr_RegionImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "RegionImage");
			RegionUnlockedCanvas.NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "region");
			RegionUnlockedCanvas.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681455);
			RegionUnlockedCanvas.NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681456);
			RegionUnlockedCanvas.NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681457);
			RegionUnlockedCanvas.NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681458);
			RegionUnlockedCanvas.NativeMethodInfoPtr_QueueUnlocked_Public_Void_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681459);
			RegionUnlockedCanvas.NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681460);
			RegionUnlockedCanvas.NativeMethodInfoPtr_EndEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681461);
			RegionUnlockedCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, 100681462);
		}

		// Token: 0x17002CD9 RID: 11481
		// (get) Token: 0x06009244 RID: 37444 RVA: 0x0025BD18 File Offset: 0x00259F18
		// (set) Token: 0x06009245 RID: 37445 RVA: 0x0025BD54 File Offset: 0x00259F54
		public unsafe virtual bool IsRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002CDA RID: 11482
		// (get) Token: 0x06009246 RID: 37446 RVA: 0x0025BD94 File Offset: 0x00259F94
		// (set) Token: 0x06009247 RID: 37447 RVA: 0x0025BDD0 File Offset: 0x00259FD0
		public unsafe virtual int Order
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 178835, RefRangeEnd = 178836, XrefRangeStart = 178835, XrefRangeEnd = 178836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009248 RID: 37448 RVA: 0x0025BE10 File Offset: 0x0025A010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264255, RefRangeEnd = 264256, XrefRangeStart = 264249, XrefRangeEnd = 264255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueUnlocked(EMapRegion _region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_QueueUnlocked_Public_Void_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009249 RID: 37449 RVA: 0x0025BE50 File Offset: 0x0025A050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264256, XrefRangeEnd = 264344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600924A RID: 37450 RVA: 0x0025BE84 File Offset: 0x0025A084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264344, XrefRangeEnd = 264347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr_EndEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600924B RID: 37451 RVA: 0x0025BEB8 File Offset: 0x0025A0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264347, XrefRangeEnd = 264350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegionUnlockedCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600924C RID: 37452 RVA: 0x00046C2E File Offset: 0x00044E2E
		public RegionUnlockedCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CD2 RID: 11474
		// (get) Token: 0x0600924D RID: 37453 RVA: 0x0025BEF4 File Offset: 0x0025A0F4
		// (set) Token: 0x0600924E RID: 37454 RVA: 0x00046C37 File Offset: 0x00044E37
		public unsafe bool _IsRunning_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField)) = value;
			}
		}

		// Token: 0x17002CD3 RID: 11475
		// (get) Token: 0x0600924F RID: 37455 RVA: 0x0025BF1C File Offset: 0x0025A11C
		// (set) Token: 0x06009250 RID: 37456 RVA: 0x00046C52 File Offset: 0x00044E52
		public unsafe int _Order_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr__Order_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr__Order_k__BackingField)) = value;
			}
		}

		// Token: 0x17002CD4 RID: 11476
		// (get) Token: 0x06009251 RID: 37457 RVA: 0x0025BF44 File Offset: 0x0025A144
		// (set) Token: 0x06009252 RID: 37458 RVA: 0x00046C6D File Offset: 0x00044E6D
		public unsafe Animation OpenCloseAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_OpenCloseAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_OpenCloseAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CD5 RID: 11477
		// (get) Token: 0x06009253 RID: 37459 RVA: 0x0025BF74 File Offset: 0x0025A174
		// (set) Token: 0x06009254 RID: 37460 RVA: 0x00046C8C File Offset: 0x00044E8C
		public unsafe TextMeshProUGUI RegionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CD6 RID: 11478
		// (get) Token: 0x06009255 RID: 37461 RVA: 0x0025BFA4 File Offset: 0x0025A1A4
		// (set) Token: 0x06009256 RID: 37462 RVA: 0x00046CAB File Offset: 0x00044EAB
		public unsafe TextMeshProUGUI RegionDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CD7 RID: 11479
		// (get) Token: 0x06009257 RID: 37463 RVA: 0x0025BFD4 File Offset: 0x0025A1D4
		// (set) Token: 0x06009258 RID: 37464 RVA: 0x00046CCA File Offset: 0x00044ECA
		public unsafe Image RegionImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_RegionImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CD8 RID: 11480
		// (get) Token: 0x06009259 RID: 37465 RVA: 0x0025C004 File Offset: 0x0025A204
		// (set) Token: 0x0600925A RID: 37466 RVA: 0x00046CE9 File Offset: 0x00044EE9
		public unsafe EMapRegion region
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_region);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionUnlockedCanvas.NativeFieldInfoPtr_region)) = value;
			}
		}

		// Token: 0x040062D2 RID: 25298
		private static readonly IntPtr NativeFieldInfoPtr__IsRunning_k__BackingField;

		// Token: 0x040062D3 RID: 25299
		private static readonly IntPtr NativeFieldInfoPtr__Order_k__BackingField;

		// Token: 0x040062D4 RID: 25300
		private static readonly IntPtr NativeFieldInfoPtr_OpenCloseAnim;

		// Token: 0x040062D5 RID: 25301
		private static readonly IntPtr NativeFieldInfoPtr_RegionLabel;

		// Token: 0x040062D6 RID: 25302
		private static readonly IntPtr NativeFieldInfoPtr_RegionDescription;

		// Token: 0x040062D7 RID: 25303
		private static readonly IntPtr NativeFieldInfoPtr_RegionImage;

		// Token: 0x040062D8 RID: 25304
		private static readonly IntPtr NativeFieldInfoPtr_region;

		// Token: 0x040062D9 RID: 25305
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040062DA RID: 25306
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0;

		// Token: 0x040062DB RID: 25307
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040062DC RID: 25308
		private static readonly IntPtr NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0;

		// Token: 0x040062DD RID: 25309
		private static readonly IntPtr NativeMethodInfoPtr_QueueUnlocked_Public_Void_EMapRegion_0;

		// Token: 0x040062DE RID: 25310
		private static readonly IntPtr NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0;

		// Token: 0x040062DF RID: 25311
		private static readonly IntPtr NativeMethodInfoPtr_EndEvent_Public_Void_0;

		// Token: 0x040062E0 RID: 25312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B4E RID: 2894
		[ObfuscatedName("ScheduleOne.UI.RegionUnlockedCanvas+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D986 RID: 55686 RVA: 0x003399CC File Offset: 0x00337BCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegionUnlockedCanvas>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr);
				RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, "<>9");
				RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, "<>9__14_0");
				RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, "<>9__14_1");
				RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, "<>9__14_2");
				RegionUnlockedCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, 100681464);
				RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__14_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, 100681465);
				RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__14_1_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, 100681466);
				RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__14_2_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr, 100681467);
			}

			// Token: 0x0600D987 RID: 55687 RVA: 0x00339A98 File Offset: 0x00337C98
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionUnlockedCanvas.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D988 RID: 55688 RVA: 0x00339AD4 File Offset: 0x00337CD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264239, XrefRangeEnd = 264247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartEvent_b__14_0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__14_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D989 RID: 55689 RVA: 0x00339B24 File Offset: 0x00337D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264247, XrefRangeEnd = 264248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartEvent_b__14_1(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__14_1_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D98A RID: 55690 RVA: 0x00339B74 File Offset: 0x00337D74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264248, XrefRangeEnd = 264249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartEvent_b__14_2(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionUnlockedCanvas.__c.NativeMethodInfoPtr__StartEvent_b__14_2_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D98B RID: 55691 RVA: 0x00069F43 File Offset: 0x00068143
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700437E RID: 17278
			// (get) Token: 0x0600D98C RID: 55692 RVA: 0x00339BC4 File Offset: 0x00337DC4
			// (set) Token: 0x0600D98D RID: 55693 RVA: 0x00069F4C File Offset: 0x0006814C
			public unsafe static RegionUnlockedCanvas.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegionUnlockedCanvas.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700437F RID: 17279
			// (get) Token: 0x0600D98E RID: 55694 RVA: 0x00339BEC File Offset: 0x00337DEC
			// (set) Token: 0x0600D98F RID: 55695 RVA: 0x00069F5E File Offset: 0x0006815E
			public unsafe static Func<NPC, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004380 RID: 17280
			// (get) Token: 0x0600D990 RID: 55696 RVA: 0x00339C14 File Offset: 0x00337E14
			// (set) Token: 0x0600D991 RID: 55697 RVA: 0x00069F70 File Offset: 0x00068170
			public unsafe static Func<NPC, bool> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004381 RID: 17281
			// (get) Token: 0x0600D992 RID: 55698 RVA: 0x00339C3C File Offset: 0x00337E3C
			// (set) Token: 0x0600D993 RID: 55699 RVA: 0x00069F82 File Offset: 0x00068182
			public unsafe static Func<NPC, bool> __9__14_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RegionUnlockedCanvas.__c.NativeFieldInfoPtr___9__14_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400921B RID: 37403
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400921C RID: 37404
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x0400921D RID: 37405
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x0400921E RID: 37406
			private static readonly IntPtr NativeFieldInfoPtr___9__14_2;

			// Token: 0x0400921F RID: 37407
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009220 RID: 37408
			private static readonly IntPtr NativeMethodInfoPtr__StartEvent_b__14_0_Internal_Boolean_NPC_0;

			// Token: 0x04009221 RID: 37409
			private static readonly IntPtr NativeMethodInfoPtr__StartEvent_b__14_1_Internal_Boolean_NPC_0;

			// Token: 0x04009222 RID: 37410
			private static readonly IntPtr NativeMethodInfoPtr__StartEvent_b__14_2_Internal_Boolean_NPC_0;
		}
	}
}
