using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000C8 RID: 200
	public class SpillController : MonoBehaviour
	{
		// Token: 0x06000ED5 RID: 3797 RVA: 0x0009F94C File Offset: 0x0009DB4C
		// Note: this type is marked as 'beforefieldinit'.
		static SpillController()
		{
			Il2CppClassPointerStore<SpillController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "SpillController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpillController>.NativeClassPtr);
			SpillController.NativeFieldInfoPtr_spill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpillController>.NativeClassPtr, "spill");
			SpillController.NativeFieldInfoPtr_lv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpillController>.NativeClassPtr, "lv");
			SpillController.NativeFieldInfoPtr_dropTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpillController>.NativeClassPtr, "dropTemplates");
			SpillController.NativeFieldInfoPtr_DROP_TEMPLATES_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpillController>.NativeClassPtr, "DROP_TEMPLATES_COUNT");
			SpillController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController>.NativeClassPtr, 100665060);
			SpillController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController>.NativeClassPtr, 100665061);
			SpillController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController>.NativeClassPtr, 100665062);
			SpillController.NativeMethodInfoPtr_DestroySpill_Private_IEnumerator_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController>.NativeClassPtr, 100665063);
			SpillController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController>.NativeClassPtr, 100665064);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0009FA30 File Offset: 0x0009DC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85964, XrefRangeEnd = 85991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0009FA64 File Offset: 0x0009DC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85991, XrefRangeEnd = 86003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0009FA98 File Offset: 0x0009DC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86003, XrefRangeEnd = 86033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0009FACC File Offset: 0x0009DCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86033, XrefRangeEnd = 86038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DestroySpill(GameObject spill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spill);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController.NativeMethodInfoPtr_DestroySpill_Private_IEnumerator_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0009FB1C File Offset: 0x0009DD1C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpillController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpillController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00009481 File Offset: 0x00007681
		public SpillController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x0009FB58 File Offset: 0x0009DD58
		// (set) Token: 0x06000EDD RID: 3805 RVA: 0x0000948A File Offset: 0x0000768A
		public unsafe GameObject spill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController.NativeFieldInfoPtr_spill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController.NativeFieldInfoPtr_spill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x0009FB88 File Offset: 0x0009DD88
		// (set) Token: 0x06000EDF RID: 3807 RVA: 0x000094A9 File Offset: 0x000076A9
		public unsafe LiquidVolume lv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController.NativeFieldInfoPtr_lv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController.NativeFieldInfoPtr_lv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x0009FBB8 File Offset: 0x0009DDB8
		// (set) Token: 0x06000EE1 RID: 3809 RVA: 0x000094C8 File Offset: 0x000076C8
		public unsafe Il2CppReferenceArray<GameObject> dropTemplates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController.NativeFieldInfoPtr_dropTemplates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController.NativeFieldInfoPtr_dropTemplates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x0009FBE8 File Offset: 0x0009DDE8
		// (set) Token: 0x06000EE3 RID: 3811 RVA: 0x000094E7 File Offset: 0x000076E7
		public unsafe static int DROP_TEMPLATES_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SpillController.NativeFieldInfoPtr_DROP_TEMPLATES_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpillController.NativeFieldInfoPtr_DROP_TEMPLATES_COUNT, (void*)(&value));
			}
		}

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeFieldInfoPtr_spill;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeFieldInfoPtr_lv;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeFieldInfoPtr_dropTemplates;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeFieldInfoPtr_DROP_TEMPLATES_COUNT;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_DestroySpill_Private_IEnumerator_GameObject_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000846 RID: 2118
		[ObfuscatedName("LiquidVolumeFX.SpillController+<DestroySpill>d__7")]
		public sealed class _DestroySpill_d__7 : Il2CppSystem.Object
		{
			// Token: 0x0600BF8B RID: 49035 RVA: 0x002EECF8 File Offset: 0x002ECEF8
			// Note: this type is marked as 'beforefieldinit'.
			static _DestroySpill_d__7()
			{
				Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpillController>.NativeClassPtr, "<DestroySpill>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr);
				SpillController._DestroySpill_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr, "<>1__state");
				SpillController._DestroySpill_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr, "<>2__current");
				SpillController._DestroySpill_d__7.NativeFieldInfoPtr_spill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr, "spill");
				SpillController._DestroySpill_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr, 100665065);
				SpillController._DestroySpill_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr, 100665066);
				SpillController._DestroySpill_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr, 100665067);
				SpillController._DestroySpill_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr, 100665068);
				SpillController._DestroySpill_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr, 100665069);
				SpillController._DestroySpill_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr, 100665070);
			}

			// Token: 0x0600BF8C RID: 49036 RVA: 0x002EEDD8 File Offset: 0x002ECFD8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DestroySpill_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpillController._DestroySpill_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController._DestroySpill_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BF8D RID: 49037 RVA: 0x002EEE20 File Offset: 0x002ED020
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController._DestroySpill_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BF8E RID: 49038 RVA: 0x002EEE54 File Offset: 0x002ED054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85953, XrefRangeEnd = 85959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController._DestroySpill_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B98 RID: 15256
			// (get) Token: 0x0600BF8F RID: 49039 RVA: 0x002EEE90 File Offset: 0x002ED090
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController._DestroySpill_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BF90 RID: 49040 RVA: 0x002EEED0 File Offset: 0x002ED0D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85959, XrefRangeEnd = 85964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController._DestroySpill_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B99 RID: 15257
			// (get) Token: 0x0600BF91 RID: 49041 RVA: 0x002EEF04 File Offset: 0x002ED104
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpillController._DestroySpill_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BF92 RID: 49042 RVA: 0x0005D970 File Offset: 0x0005BB70
			public _DestroySpill_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B95 RID: 15253
			// (get) Token: 0x0600BF93 RID: 49043 RVA: 0x002EEF44 File Offset: 0x002ED144
			// (set) Token: 0x0600BF94 RID: 49044 RVA: 0x0005D979 File Offset: 0x0005BB79
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController._DestroySpill_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController._DestroySpill_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003B96 RID: 15254
			// (get) Token: 0x0600BF95 RID: 49045 RVA: 0x002EEF6C File Offset: 0x002ED16C
			// (set) Token: 0x0600BF96 RID: 49046 RVA: 0x0005D994 File Offset: 0x0005BB94
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController._DestroySpill_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController._DestroySpill_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B97 RID: 15255
			// (get) Token: 0x0600BF97 RID: 49047 RVA: 0x002EEF9C File Offset: 0x002ED19C
			// (set) Token: 0x0600BF98 RID: 49048 RVA: 0x0005D9B3 File Offset: 0x0005BBB3
			public unsafe GameObject spill
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController._DestroySpill_d__7.NativeFieldInfoPtr_spill);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpillController._DestroySpill_d__7.NativeFieldInfoPtr_spill), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040081CD RID: 33229
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040081CE RID: 33230
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040081CF RID: 33231
			private static readonly IntPtr NativeFieldInfoPtr_spill;

			// Token: 0x040081D0 RID: 33232
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040081D1 RID: 33233
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040081D2 RID: 33234
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040081D3 RID: 33235
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040081D4 RID: 33236
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040081D5 RID: 33237
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
