using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x02000513 RID: 1299
	public class Sweatshop : Property
	{
		// Token: 0x06007371 RID: 29553 RVA: 0x001F8020 File Offset: 0x001F6220
		// Note: this type is marked as 'beforefieldinit'.
		static Sweatshop()
		{
			Il2CppClassPointerStore<Sweatshop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "Sweatshop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr);
			Sweatshop.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.SweatshopAssembly-CSharp.dll_Excuted");
			Sweatshop.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.SweatshopAssembly-CSharp.dll_Excuted");
			Sweatshop.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100677809);
			Sweatshop.NativeMethodInfoPtr_UpdateVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100677810);
			Sweatshop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100677811);
			Sweatshop.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100677812);
			Sweatshop.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100677813);
			Sweatshop.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100677814);
			Sweatshop.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100677815);
		}

		// Token: 0x06007372 RID: 29554 RVA: 0x001F8104 File Offset: 0x001F6304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225861, XrefRangeEnd = 225865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sweatshop.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007373 RID: 29555 RVA: 0x001F8140 File Offset: 0x001F6340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225865, XrefRangeEnd = 225962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sweatshop.NativeMethodInfoPtr_UpdateVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007374 RID: 29556 RVA: 0x001F8174 File Offset: 0x001F6374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225962, XrefRangeEnd = 225966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sweatshop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sweatshop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007375 RID: 29557 RVA: 0x001F81B0 File Offset: 0x001F63B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sweatshop.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007376 RID: 29558 RVA: 0x001F81EC File Offset: 0x001F63EC
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sweatshop.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007377 RID: 29559 RVA: 0x001F8228 File Offset: 0x001F6428
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sweatshop.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007378 RID: 29560 RVA: 0x001F8264 File Offset: 0x001F6464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sweatshop.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007379 RID: 29561 RVA: 0x00036DFF File Offset: 0x00034FFF
		public Sweatshop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002303 RID: 8963
		// (get) Token: 0x0600737A RID: 29562 RVA: 0x001F82A0 File Offset: 0x001F64A0
		// (set) Token: 0x0600737B RID: 29563 RVA: 0x00036E08 File Offset: 0x00035008
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sweatshop.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sweatshop.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002304 RID: 8964
		// (get) Token: 0x0600737C RID: 29564 RVA: 0x001F82C8 File Offset: 0x001F64C8
		// (set) Token: 0x0600737D RID: 29565 RVA: 0x00036E23 File Offset: 0x00035023
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sweatshop.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sweatshop.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004ED0 RID: 20176
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004ED1 RID: 20177
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004ED2 RID: 20178
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004ED3 RID: 20179
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVariables_Private_Void_0;

		// Token: 0x04004ED4 RID: 20180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004ED5 RID: 20181
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004ED6 RID: 20182
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004ED7 RID: 20183
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004ED8 RID: 20184
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A8C RID: 2700
		[ObfuscatedName("ScheduleOne.Property.Sweatshop+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600D255 RID: 53845 RVA: 0x003251DC File Offset: 0x003233DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr);
				Sweatshop.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr, "<>9");
				Sweatshop.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr, "<>9__1_0");
				Sweatshop.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr, "<>9__1_1");
				Sweatshop.__c.NativeFieldInfoPtr___9__1_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr, "<>9__1_2");
				Sweatshop.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr, 100677817);
				Sweatshop.__c.NativeMethodInfoPtr__UpdateVariables_b__1_0_Internal_Boolean_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr, 100677818);
				Sweatshop.__c.NativeMethodInfoPtr__UpdateVariables_b__1_1_Internal_Pot_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr, 100677819);
				Sweatshop.__c.NativeMethodInfoPtr__UpdateVariables_b__1_2_Internal_Boolean_Additive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr, 100677820);
			}

			// Token: 0x0600D256 RID: 53846 RVA: 0x003252A8 File Offset: 0x003234A8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sweatshop.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D257 RID: 53847 RVA: 0x003252E4 File Offset: 0x003234E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225855, XrefRangeEnd = 225856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__1_0(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sweatshop.__c.NativeMethodInfoPtr__UpdateVariables_b__1_0_Internal_Boolean_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D258 RID: 53848 RVA: 0x00325334 File Offset: 0x00323534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225856, XrefRangeEnd = 225857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Pot _UpdateVariables_b__1_1(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sweatshop.__c.NativeMethodInfoPtr__UpdateVariables_b__1_1_Internal_Pot_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
			}

			// Token: 0x0600D259 RID: 53849 RVA: 0x00325384 File Offset: 0x00323584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225857, XrefRangeEnd = 225861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__1_2(Additive x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sweatshop.__c.NativeMethodInfoPtr__UpdateVariables_b__1_2_Internal_Boolean_Additive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D25A RID: 53850 RVA: 0x0006665D File Offset: 0x0006485D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004143 RID: 16707
			// (get) Token: 0x0600D25B RID: 53851 RVA: 0x003253D4 File Offset: 0x003235D4
			// (set) Token: 0x0600D25C RID: 53852 RVA: 0x00066666 File Offset: 0x00064866
			public unsafe static Sweatshop.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Sweatshop.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sweatshop.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Sweatshop.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004144 RID: 16708
			// (get) Token: 0x0600D25D RID: 53853 RVA: 0x003253FC File Offset: 0x003235FC
			// (set) Token: 0x0600D25E RID: 53854 RVA: 0x00066678 File Offset: 0x00064878
			public unsafe static Func<BuildableItem, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Sweatshop.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BuildableItem, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Sweatshop.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004145 RID: 16709
			// (get) Token: 0x0600D25F RID: 53855 RVA: 0x00325424 File Offset: 0x00323624
			// (set) Token: 0x0600D260 RID: 53856 RVA: 0x0006668A File Offset: 0x0006488A
			public unsafe static Func<BuildableItem, Pot> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Sweatshop.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BuildableItem, Pot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Sweatshop.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004146 RID: 16710
			// (get) Token: 0x0600D261 RID: 53857 RVA: 0x0032544C File Offset: 0x0032364C
			// (set) Token: 0x0600D262 RID: 53858 RVA: 0x0006669C File Offset: 0x0006489C
			public unsafe static Predicate<Additive> __9__1_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Sweatshop.__c.NativeFieldInfoPtr___9__1_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Additive>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Sweatshop.__c.NativeFieldInfoPtr___9__1_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DD8 RID: 36312
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008DD9 RID: 36313
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04008DDA RID: 36314
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x04008DDB RID: 36315
			private static readonly IntPtr NativeFieldInfoPtr___9__1_2;

			// Token: 0x04008DDC RID: 36316
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DDD RID: 36317
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__1_0_Internal_Boolean_BuildableItem_0;

			// Token: 0x04008DDE RID: 36318
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__1_1_Internal_Pot_BuildableItem_0;

			// Token: 0x04008DDF RID: 36319
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__1_2_Internal_Boolean_Additive_0;
		}
	}
}
