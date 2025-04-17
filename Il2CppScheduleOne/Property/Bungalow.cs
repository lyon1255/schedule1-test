using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x02000509 RID: 1289
	public class Bungalow : Property
	{
		// Token: 0x0600720D RID: 29197 RVA: 0x001F2F14 File Offset: 0x001F1114
		// Note: this type is marked as 'beforefieldinit'.
		static Bungalow()
		{
			Il2CppClassPointerStore<Bungalow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "Bungalow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bungalow>.NativeClassPtr);
			Bungalow.NativeFieldInfoPtr_ModelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, "ModelContainer");
			Bungalow.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.BungalowAssembly-CSharp.dll_Excuted");
			Bungalow.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.BungalowAssembly-CSharp.dll_Excuted");
			Bungalow.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677592);
			Bungalow.NativeMethodInfoPtr_UpdateVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677593);
			Bungalow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677594);
			Bungalow.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677595);
			Bungalow.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677596);
			Bungalow.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677597);
			Bungalow.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677598);
		}

		// Token: 0x0600720E RID: 29198 RVA: 0x001F300C File Offset: 0x001F120C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223573, XrefRangeEnd = 223577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bungalow.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600720F RID: 29199 RVA: 0x001F3048 File Offset: 0x001F1248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223577, XrefRangeEnd = 223700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bungalow.NativeMethodInfoPtr_UpdateVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007210 RID: 29200 RVA: 0x001F307C File Offset: 0x001F127C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223700, XrefRangeEnd = 223704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bungalow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bungalow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bungalow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007211 RID: 29201 RVA: 0x001F30B8 File Offset: 0x001F12B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223704, XrefRangeEnd = 223705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bungalow.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007212 RID: 29202 RVA: 0x001F30F4 File Offset: 0x001F12F4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bungalow.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007213 RID: 29203 RVA: 0x001F3130 File Offset: 0x001F1330
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bungalow.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007214 RID: 29204 RVA: 0x001F316C File Offset: 0x001F136C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223705, XrefRangeEnd = 223706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bungalow.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007215 RID: 29205 RVA: 0x0003649C File Offset: 0x0003469C
		public Bungalow(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002290 RID: 8848
		// (get) Token: 0x06007216 RID: 29206 RVA: 0x001F31A8 File Offset: 0x001F13A8
		// (set) Token: 0x06007217 RID: 29207 RVA: 0x000364A5 File Offset: 0x000346A5
		public unsafe Transform ModelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bungalow.NativeFieldInfoPtr_ModelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bungalow.NativeFieldInfoPtr_ModelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002291 RID: 8849
		// (get) Token: 0x06007218 RID: 29208 RVA: 0x001F31D8 File Offset: 0x001F13D8
		// (set) Token: 0x06007219 RID: 29209 RVA: 0x000364C4 File Offset: 0x000346C4
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bungalow.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bungalow.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002292 RID: 8850
		// (get) Token: 0x0600721A RID: 29210 RVA: 0x001F3200 File Offset: 0x001F1400
		// (set) Token: 0x0600721B RID: 29211 RVA: 0x000364DF File Offset: 0x000346DF
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bungalow.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bungalow.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004DD2 RID: 19922
		private static readonly IntPtr NativeFieldInfoPtr_ModelContainer;

		// Token: 0x04004DD3 RID: 19923
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004DD4 RID: 19924
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004DD5 RID: 19925
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004DD6 RID: 19926
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVariables_Private_Void_0;

		// Token: 0x04004DD7 RID: 19927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004DD8 RID: 19928
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004DD9 RID: 19929
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004DDA RID: 19930
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004DDB RID: 19931
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A81 RID: 2689
		[ObfuscatedName("ScheduleOne.Property.Bungalow+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D1E8 RID: 53736 RVA: 0x00323CC0 File Offset: 0x00321EC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr);
				Bungalow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, "<>9");
				Bungalow.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, "<>9__2_0");
				Bungalow.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, "<>9__2_1");
				Bungalow.__c.NativeFieldInfoPtr___9__2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, "<>9__2_2");
				Bungalow.__c.NativeFieldInfoPtr___9__2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, "<>9__2_3");
				Bungalow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, 100677600);
				Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_0_Internal_Boolean_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, 100677601);
				Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_1_Internal_Pot_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, 100677602);
				Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_2_Internal_Boolean_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, 100677603);
				Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_3_Internal_Boolean_Additive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, 100677604);
			}

			// Token: 0x0600D1E9 RID: 53737 RVA: 0x00323DB4 File Offset: 0x00321FB4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bungalow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1EA RID: 53738 RVA: 0x00323DF0 File Offset: 0x00321FF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223566, XrefRangeEnd = 223567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__2_0(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_0_Internal_Boolean_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D1EB RID: 53739 RVA: 0x00323E40 File Offset: 0x00322040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223567, XrefRangeEnd = 223568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Pot _UpdateVariables_b__2_1(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_1_Internal_Pot_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
			}

			// Token: 0x0600D1EC RID: 53740 RVA: 0x00323E90 File Offset: 0x00322090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223568, XrefRangeEnd = 223569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__2_2(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_2_Internal_Boolean_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D1ED RID: 53741 RVA: 0x00323EE0 File Offset: 0x003220E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223569, XrefRangeEnd = 223573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__2_3(Additive x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_3_Internal_Boolean_Additive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D1EE RID: 53742 RVA: 0x000663D1 File Offset: 0x000645D1
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700412A RID: 16682
			// (get) Token: 0x0600D1EF RID: 53743 RVA: 0x00323F30 File Offset: 0x00322130
			// (set) Token: 0x0600D1F0 RID: 53744 RVA: 0x000663DA File Offset: 0x000645DA
			public unsafe static Bungalow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bungalow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Bungalow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bungalow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700412B RID: 16683
			// (get) Token: 0x0600D1F1 RID: 53745 RVA: 0x00323F58 File Offset: 0x00322158
			// (set) Token: 0x0600D1F2 RID: 53746 RVA: 0x000663EC File Offset: 0x000645EC
			public unsafe static Func<BuildableItem, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bungalow.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BuildableItem, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bungalow.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700412C RID: 16684
			// (get) Token: 0x0600D1F3 RID: 53747 RVA: 0x00323F80 File Offset: 0x00322180
			// (set) Token: 0x0600D1F4 RID: 53748 RVA: 0x000663FE File Offset: 0x000645FE
			public unsafe static Func<BuildableItem, Pot> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bungalow.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BuildableItem, Pot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bungalow.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700412D RID: 16685
			// (get) Token: 0x0600D1F5 RID: 53749 RVA: 0x00323FA8 File Offset: 0x003221A8
			// (set) Token: 0x0600D1F6 RID: 53750 RVA: 0x00066410 File Offset: 0x00064610
			public unsafe static Func<BuildableItem, bool> __9__2_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bungalow.__c.NativeFieldInfoPtr___9__2_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BuildableItem, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bungalow.__c.NativeFieldInfoPtr___9__2_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700412E RID: 16686
			// (get) Token: 0x0600D1F7 RID: 53751 RVA: 0x00323FD0 File Offset: 0x003221D0
			// (set) Token: 0x0600D1F8 RID: 53752 RVA: 0x00066422 File Offset: 0x00064622
			public unsafe static Predicate<Additive> __9__2_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bungalow.__c.NativeFieldInfoPtr___9__2_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Additive>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bungalow.__c.NativeFieldInfoPtr___9__2_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D9B RID: 36251
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008D9C RID: 36252
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04008D9D RID: 36253
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x04008D9E RID: 36254
			private static readonly IntPtr NativeFieldInfoPtr___9__2_2;

			// Token: 0x04008D9F RID: 36255
			private static readonly IntPtr NativeFieldInfoPtr___9__2_3;

			// Token: 0x04008DA0 RID: 36256
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DA1 RID: 36257
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__2_0_Internal_Boolean_BuildableItem_0;

			// Token: 0x04008DA2 RID: 36258
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__2_1_Internal_Pot_BuildableItem_0;

			// Token: 0x04008DA3 RID: 36259
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__2_2_Internal_Boolean_BuildableItem_0;

			// Token: 0x04008DA4 RID: 36260
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__2_3_Internal_Boolean_Additive_0;
		}
	}
}
