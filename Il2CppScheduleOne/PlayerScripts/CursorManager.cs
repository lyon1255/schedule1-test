using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003DF RID: 991
	public class CursorManager : Singleton<CursorManager>
	{
		// Token: 0x06004CA5 RID: 19621 RVA: 0x001701D0 File Offset: 0x0016E3D0
		// Note: this type is marked as 'beforefieldinit'.
		static CursorManager()
		{
			Il2CppClassPointerStore<CursorManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "CursorManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorManager>.NativeClassPtr);
			CursorManager.NativeFieldInfoPtr_Cursors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "Cursors");
			CursorManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100672758);
			CursorManager.NativeMethodInfoPtr_SetCursorAppearance_Public_Void_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100672759);
			CursorManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100672760);
		}

		// Token: 0x06004CA6 RID: 19622 RVA: 0x00170250 File Offset: 0x0016E450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165832, XrefRangeEnd = 165850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CursorManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CA7 RID: 19623 RVA: 0x0017028C File Offset: 0x0016E48C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 165865, RefRangeEnd = 165876, XrefRangeStart = 165850, XrefRangeEnd = 165865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCursorAppearance(CursorManager.ECursorType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr_SetCursorAppearance_Public_Void_ECursorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CA8 RID: 19624 RVA: 0x001702CC File Offset: 0x0016E4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165876, XrefRangeEnd = 165886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CursorManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CA9 RID: 19625 RVA: 0x00024DB9 File Offset: 0x00022FB9
		public CursorManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x06004CAA RID: 19626 RVA: 0x00170308 File Offset: 0x0016E508
		// (set) Token: 0x06004CAB RID: 19627 RVA: 0x00024DC2 File Offset: 0x00022FC2
		public unsafe List<CursorManager.CursorConfig> Cursors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr_Cursors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CursorManager.CursorConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr_Cursors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400339E RID: 13214
		private static readonly IntPtr NativeFieldInfoPtr_Cursors;

		// Token: 0x0400339F RID: 13215
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040033A0 RID: 13216
		private static readonly IntPtr NativeMethodInfoPtr_SetCursorAppearance_Public_Void_ECursorType_0;

		// Token: 0x040033A1 RID: 13217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200098B RID: 2443
		[OriginalName("Assembly-CSharp.dll", "", "ECursorType")]
		public enum ECursorType
		{
			// Token: 0x040088E1 RID: 35041
			Default,
			// Token: 0x040088E2 RID: 35042
			Finger,
			// Token: 0x040088E3 RID: 35043
			OpenHand,
			// Token: 0x040088E4 RID: 35044
			Grab,
			// Token: 0x040088E5 RID: 35045
			Scissors
		}

		// Token: 0x0200098C RID: 2444
		[Serializable]
		public class CursorConfig : Il2CppSystem.Object
		{
			// Token: 0x0600CA59 RID: 51801 RVA: 0x0030EE88 File Offset: 0x0030D088
			// Note: this type is marked as 'beforefieldinit'.
			static CursorConfig()
			{
				Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "CursorConfig");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr);
				CursorManager.CursorConfig.NativeFieldInfoPtr_CursorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr, "CursorType");
				CursorManager.CursorConfig.NativeFieldInfoPtr_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr, "Texture");
				CursorManager.CursorConfig.NativeFieldInfoPtr_HotSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr, "HotSpot");
				CursorManager.CursorConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr, 100672761);
			}

			// Token: 0x0600CA5A RID: 51802 RVA: 0x0030EF04 File Offset: 0x0030D104
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CursorConfig() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.CursorConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA5B RID: 51803 RVA: 0x000625F1 File Offset: 0x000607F1
			public CursorConfig(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F0B RID: 16139
			// (get) Token: 0x0600CA5C RID: 51804 RVA: 0x0030EF40 File Offset: 0x0030D140
			// (set) Token: 0x0600CA5D RID: 51805 RVA: 0x000625FA File Offset: 0x000607FA
			public unsafe CursorManager.ECursorType CursorType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_CursorType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_CursorType)) = value;
				}
			}

			// Token: 0x17003F0C RID: 16140
			// (get) Token: 0x0600CA5E RID: 51806 RVA: 0x0030EF68 File Offset: 0x0030D168
			// (set) Token: 0x0600CA5F RID: 51807 RVA: 0x00062615 File Offset: 0x00060815
			public unsafe Texture2D Texture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_Texture);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_Texture), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F0D RID: 16141
			// (get) Token: 0x0600CA60 RID: 51808 RVA: 0x0030EF98 File Offset: 0x0030D198
			// (set) Token: 0x0600CA61 RID: 51809 RVA: 0x00062634 File Offset: 0x00060834
			public unsafe Vector2 HotSpot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_HotSpot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_HotSpot)) = value;
				}
			}

			// Token: 0x040088E6 RID: 35046
			private static readonly IntPtr NativeFieldInfoPtr_CursorType;

			// Token: 0x040088E7 RID: 35047
			private static readonly IntPtr NativeFieldInfoPtr_Texture;

			// Token: 0x040088E8 RID: 35048
			private static readonly IntPtr NativeFieldInfoPtr_HotSpot;

			// Token: 0x040088E9 RID: 35049
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200098D RID: 2445
		[ObfuscatedName("ScheduleOne.PlayerScripts.CursorManager+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CA62 RID: 51810 RVA: 0x0030EFC0 File Offset: 0x0030D1C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr);
				CursorManager.__c__DisplayClass4_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr, "type");
				CursorManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr, 100672762);
				CursorManager.__c__DisplayClass4_0.NativeMethodInfoPtr__SetCursorAppearance_b__0_Internal_Boolean_CursorConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr, 100672763);
			}

			// Token: 0x0600CA63 RID: 51811 RVA: 0x0030F028 File Offset: 0x0030D228
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA64 RID: 51812 RVA: 0x0030F064 File Offset: 0x0030D264
			[CallerCount(0)]
			public unsafe bool _SetCursorAppearance_b__0(CursorManager.CursorConfig x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.__c__DisplayClass4_0.NativeMethodInfoPtr__SetCursorAppearance_b__0_Internal_Boolean_CursorConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CA65 RID: 51813 RVA: 0x0006264F File Offset: 0x0006084F
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F0E RID: 16142
			// (get) Token: 0x0600CA66 RID: 51814 RVA: 0x0030F0B4 File Offset: 0x0030D2B4
			// (set) Token: 0x0600CA67 RID: 51815 RVA: 0x00062658 File Offset: 0x00060858
			public unsafe CursorManager.ECursorType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.__c__DisplayClass4_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.__c__DisplayClass4_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x040088EA RID: 35050
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x040088EB RID: 35051
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088EC RID: 35052
			private static readonly IntPtr NativeMethodInfoPtr__SetCursorAppearance_b__0_Internal_Boolean_CursorConfig_0;
		}
	}
}
